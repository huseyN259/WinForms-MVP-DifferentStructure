using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WinF_MVP.Models;

namespace WinF_MVP.Repositories.Contexts;

public class MyDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), "AppSettings.json");
        IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile(path, false);
        IConfigurationRoot root = builder.Build();
        var sqlConnectionString = root.GetConnectionString("DefaultConnectionStr");
        optionsBuilder.UseSqlServer(sqlConnectionString);
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Student>? Students { get; set; }
}