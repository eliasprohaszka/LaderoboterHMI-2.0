using Microsoft.EntityFrameworkCore;
using Laderoboter.Core.Data;
using Laderoboter.Core.Interfaces;
using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

public class WorkpieceProgramNumberService : IWorkpieceProgramNumberService
{
    private readonly IDbContextFactory<LaderoboterDbContext> _contextFactory;

    public event EventHandler? ProgramNumbersChanged;

    public WorkpieceProgramNumberService(IDbContextFactory<LaderoboterDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<int?> GetProgramNumberAsync(int paletteNumber, int position)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var entry = await context.WorkpieceProgramNumbers
            .FirstOrDefaultAsync(w => w.PaletteNumber == paletteNumber && w.Position == position);
        return entry?.ProgramNumber;
    }

    public async Task<WorkpieceProgramNumber?> SetProgramNumberAsync(int paletteNumber, int position, int programNumber)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var existing = await context.WorkpieceProgramNumbers
            .FirstOrDefaultAsync(w => w.PaletteNumber == paletteNumber && w.Position == position);

        if (existing != null)
        {
            existing.ProgramNumber = programNumber;
            existing.UpdatedAt = DateTime.Now;
        }
        else
        {
            existing = new WorkpieceProgramNumber
            {
                PaletteNumber = paletteNumber,
                Position = position,
                ProgramNumber = programNumber,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            context.WorkpieceProgramNumbers.Add(existing);
        }

        await context.SaveChangesAsync();
        OnProgramNumbersChanged();
        return existing;
    }

    public async Task<bool> RemoveProgramNumberAsync(int paletteNumber, int position)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var existing = await context.WorkpieceProgramNumbers
            .FirstOrDefaultAsync(w => w.PaletteNumber == paletteNumber && w.Position == position);

        if (existing == null)
        {
            return false;
        }

        context.WorkpieceProgramNumbers.Remove(existing);
        await context.SaveChangesAsync();
        OnProgramNumbersChanged();
        return true;
    }

    public async Task<Dictionary<(int PaletteNumber, int Position), int>> GetAllProgramNumbersAsync()
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var entries = await context.WorkpieceProgramNumbers.ToListAsync();
        return entries.ToDictionary(
            e => (e.PaletteNumber, e.Position),
            e => e.ProgramNumber
        );
    }

    private void OnProgramNumbersChanged()
    {
        ProgramNumbersChanged?.Invoke(this, EventArgs.Empty);
    }
}
