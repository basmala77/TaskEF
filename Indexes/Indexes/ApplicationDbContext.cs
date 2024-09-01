using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexes
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=EF-Index;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasIndex(b => b.URL)
                .IsUnique()
                .HasFilter(null);

          //  modelBuilder.Entity<Person>()
           //    .HasIndex(p => new { p.FName, p.LName });
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
       // public DbSet<Person> Persons { get; set; }

        public class Blog
        {
            public int BlogId { get; set; }

            public string URL { get; set; }

            public List<Post> Posts { get; set; }
        }
        public class Post
        {
            public int PostId { get; set; }
            public  int BlogId { get; set; }
            public Blog Blog { get; set; }
        }
        public class Person
        {
            public int Id { get; set; }
           
            public string FName { get; set; }
            public string LName { get; set; }
        }
    }
}
