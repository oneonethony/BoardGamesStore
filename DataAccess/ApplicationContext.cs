using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ApplicationContext : DbContext
    {
        public DbSet<BoardGame> BoardGames { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoardGame>().HasData(
                new BoardGame { Id = 1, Name = "D&D", Description = "", Price = 100, Quantity = 5 },
                new BoardGame { Id = 2, Name = "Страшные сказки", Description = "", Price = 20, Quantity = 7 },
                new BoardGame { Id = 3, Name = "Ужасы Аркхэма", Description = "", Price = 130, Quantity = 4 },
                new BoardGame { Id = 4, Name = "Дюна", Description = "", Price = 200, Quantity = 4 }
                );
        }
    }
}
