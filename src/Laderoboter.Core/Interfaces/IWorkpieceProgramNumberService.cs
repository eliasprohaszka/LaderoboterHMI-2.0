using Laderoboter.Core.Models;

namespace Laderoboter.Core.Interfaces;

public interface IWorkpieceProgramNumberService
{
    Task<int?> GetProgramNumberAsync(int paletteNumber, int position);
    Task<WorkpieceProgramNumber?> SetProgramNumberAsync(int paletteNumber, int position, int programNumber);
    Task<bool> RemoveProgramNumberAsync(int paletteNumber, int position);
    Task<Dictionary<(int PaletteNumber, int Position), int>> GetAllProgramNumbersAsync();
    event EventHandler? ProgramNumbersChanged;
}
