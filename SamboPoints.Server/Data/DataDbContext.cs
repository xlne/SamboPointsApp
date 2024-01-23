using Microsoft.EntityFrameworkCore;
using SamboPoints.Server.Models;

namespace SamboPoints.Server.Data;

public class DataDbContext : DbContext
{
    public DbSet<TodoItem> TodoItems { get; set; }
    public string DbPath { get; }

    public DataDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "samboPoints.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite($"Data Source={DbPath}");
}
