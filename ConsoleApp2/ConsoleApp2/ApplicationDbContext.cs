using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=EFCORE;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditEntry>();

            //modelBuilder.Entity<Blog>()
            //    .Property(b => b.rating)
            //    .HasDefaultValue(2);

            modelBuilder.Entity<author>().Property(p => p.Title)
                .HasComputedColumnSql("[Lname] + ', ' + [FName]");

            modelBuilder.Entity<author>()
                .Property(p => p.Description)
                .HasComputedColumnSql("[Lname] + ', ' + [FName]");
            //modelBuilder.Entity<Blog>().Property(b => b.URL).HasMaxLength(50);
            //modelBuilder.Entity<book>().HasKey(b => b.BookKey).HasName("ID");

            //modelBuilder.Entity<Category>()
            //    .Property(p => p.Id)
            //    .ValueGeneratedOnAdd();
            
                
            new BlogEntity().Configure(modelBuilder.Entity<Blog>());

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<author> authors { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}


