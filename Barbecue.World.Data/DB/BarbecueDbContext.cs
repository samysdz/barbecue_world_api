using Barbecue.World.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml;
using System.IO;

namespace Barbecue.World.Data.DB
{
    public class BarbecueDbContext : DbContext
    {
        public DbSet<Countries> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbFilePath = Environment.GetEnvironmentVariable("DB_Path_Barbecue");
            optionsBuilder.UseSqlite($"Data Source={dbFilePath}");
        }
    }

}
