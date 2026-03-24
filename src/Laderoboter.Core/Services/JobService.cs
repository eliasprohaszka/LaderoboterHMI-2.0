using Microsoft.EntityFrameworkCore;
using Laderoboter.Core.Data;
using Laderoboter.Core.Interfaces;
using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

/// <summary>
/// Service für die Verwaltung der Jobliste in der Datenbank
/// </summary>
public class JobService : IJobService
{
    private readonly IDbContextFactory<LaderoboterDbContext> _contextFactory;

    public event EventHandler? JobListChanged;

    public int MaxJobs => 16;

    public JobService(IDbContextFactory<LaderoboterDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<List<Job>> GetAllJobsAsync()
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        return await context.Jobs
            .OrderBy(j => j.SequenceNumber)
            .ToListAsync();
    }

    public async Task<Job?> AddJobAsync(int paletteNumber, int position)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        // Prüfen ob bereits vorhanden
        var exists = await context.Jobs
            .AnyAsync(j => j.PaletteNumber == paletteNumber && j.Position == position);

        if (exists)
        {
            return null;
        }

        // Prüfen ob Limit erreicht
        var count = await context.Jobs.CountAsync();
        if (count >= MaxJobs)
        {
            return null;
        }

        // Nächste Sequenznummer ermitteln
        var maxSequence = await context.Jobs.MaxAsync(j => (int?)j.SequenceNumber) ?? 0;

        var job = new Job
        {
            PaletteNumber = paletteNumber,
            Position = position,
            SequenceNumber = maxSequence + 1,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };

        context.Jobs.Add(job);
        await context.SaveChangesAsync();

        OnJobListChanged();
        return job;
    }

    public async Task<bool> RemoveJobAsync(int jobId)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var job = await context.Jobs.FindAsync(jobId);
        if (job == null)
        {
            return false;
        }

        var removedSequence = job.SequenceNumber;
        context.Jobs.Remove(job);

        // Sequenznummern nach dem entfernten Job neu nummerieren
        var jobsToUpdate = await context.Jobs
            .Where(j => j.SequenceNumber > removedSequence)
            .ToListAsync();

        foreach (var j in jobsToUpdate)
        {
            j.SequenceNumber--;
            j.UpdatedAt = DateTime.Now;
        }

        await context.SaveChangesAsync();

        OnJobListChanged();
        return true;
    }

    public async Task<bool> RemoveJobByPositionAsync(int paletteNumber, int position)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var job = await context.Jobs
            .FirstOrDefaultAsync(j => j.PaletteNumber == paletteNumber && j.Position == position);

        if (job == null)
        {
            return false;
        }

        var removedSequence = job.SequenceNumber;
        context.Jobs.Remove(job);

        // Sequenznummern nach dem entfernten Job neu nummerieren
        var jobsToUpdate = await context.Jobs
            .Where(j => j.SequenceNumber > removedSequence)
            .ToListAsync();

        foreach (var j in jobsToUpdate)
        {
            j.SequenceNumber--;
            j.UpdatedAt = DateTime.Now;
        }

        await context.SaveChangesAsync();

        OnJobListChanged();
        return true;
    }

    public async Task<bool> UpdateJobOrderAsync(List<int> jobIds)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var jobs = await context.Jobs
            .Where(j => jobIds.Contains(j.Id))
            .ToListAsync();

        if (jobs.Count != jobIds.Count)
        {
            return false;
        }

        // First pass: set all to negative temporary values to avoid unique constraint violations
        for (var i = 0; i < jobIds.Count; i++)
        {
            var job = jobs.First(j => j.Id == jobIds[i]);
            job.SequenceNumber = -(i + 1);
        }
        await context.SaveChangesAsync();

        // Second pass: set to final positive values
        for (var i = 0; i < jobIds.Count; i++)
        {
            var job = jobs.First(j => j.Id == jobIds[i]);
            job.SequenceNumber = i + 1;
            job.UpdatedAt = DateTime.Now;
        }
        await context.SaveChangesAsync();

        OnJobListChanged();
        return true;
    }

    public async Task<bool> IsWorkpieceInJobListAsync(int paletteNumber, int position)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        return await context.Jobs
            .AnyAsync(j => j.PaletteNumber == paletteNumber && j.Position == position);
    }

    public async Task<int> GetJobCountAsync()
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        return await context.Jobs.CountAsync();
    }

    public async Task ClearAllJobsAsync()
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        context.Jobs.RemoveRange(context.Jobs);
        await context.SaveChangesAsync();

        OnJobListChanged();
    }

    private void OnJobListChanged()
    {
        JobListChanged?.Invoke(this, EventArgs.Empty);
    }
}
