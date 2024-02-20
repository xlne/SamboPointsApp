using Microsoft.EntityFrameworkCore;
using SamboPoints.Server.Models;

namespace SamboPoints.Server.Data;

public class DataDbContext : DbContext
{
    public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
    {
        
    }


    //protected readonly IConfiguration _configuration;

    //public DataDbContext(IConfiguration configuration)
    //{
    //    _configuration = configuration;
    //}

    //protected override void OnConfiguring(DbContextOptionsBuilder options)
    //{
    //    options.UseSqlite(_configuration.GetConnectionString("SamboPointsDatabase"));
    //}
    public DbSet<TodoItem> TodoItems => Set<TodoItem>();
}
