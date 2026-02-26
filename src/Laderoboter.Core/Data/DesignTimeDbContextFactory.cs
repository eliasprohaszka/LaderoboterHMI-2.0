using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Laderoboter.Core.Data;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<LaderoboterDbContext>
{
    public LaderoboterDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<LaderoboterDbContext>();
        optionsBuilder.UseSqlite("Data Source=laderoboter_design.db");

        return new LaderoboterDbContext(optionsBuilder.Options);
    }
}
