// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SamboPoints.Server.Data;

Console.WriteLine("Hello, World!");

public class ContextFactory : IDesignTimeDbContextFactory<DataDbContext>
{
    public DataDbContext CreateDbContext(string[] args)
        => new(new DbContextOptionsBuilder<DataDbContext>().UseSqlite(args[0]).Options);
}

/*
 This project is created as a workaround due to a problem when creating migrations from my server project. Maybe a 
common problem when working with Blazor WASM and SQLite, I have not investigated other frameworks. 

Solution/workaround found here:
https://github.com/dotnet/EntityFramework.Docs/issues/4230
 */