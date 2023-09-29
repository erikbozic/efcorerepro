using Microsoft.EntityFrameworkCore;

namespace EFCoreRepro.Models;

public class MyDbContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TestEntity>()
            .Property(e => e.Status).HasConversion<string>();
            
        modelBuilder.Entity<TestEntity>()
            .Property(e => e.SubStatus).HasConversion<string>();
        
        modelBuilder.Entity<TestEntity>()
            .Metadata.AddCheckConstraint(
                name: "CK_TestEntity_TestEnum2",
                sql: CrateCheckSql("SubStatus"));


    }
    
    private static string CrateCheckSql(string columnName) => $"(Status = 'Status1' AND {columnName} IN ({ToSqlList<Status1_SubStatus>()}) OR Status = 'Status2' AND {columnName} IN ({ToSqlList<Status2_SubStatus>()})))";
    
    private static string ToSqlList<TEnum>() where TEnum : struct
    {
        return string.Join(',', EnumUtil.All<TEnum>().Select(@enum => $"'{@enum.GetLiteral()}'"));
    }
    
    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer($"Data Source=localhost");
}
