using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationShip
{
    public class ApplicationDbContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=EF-Test;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Blog>()
            //    .HasOne(b => b.BlogImage)
            //    .WithOne(i => i.Blog)
            //    .HasForeignKey<BlogImage>(b => b.BlogFK);

            modelBuilder.Entity<Blog>()
                .HasMany(b => b.Posts)
                .WithOne(b => b.Blog);
            //no navigation property
            //modelBuilder.Entity<Post>()
            //     .HasOne<Blog>().WithMany()
            //     .HasForeignKey(p => p.BlogId)
            //     ; 

            //change foreignKey name


            //Compaosit key
            //modelBuilder.Entity<Post>()
            //    .HasOne(b => b.Blog)
            //    .WithMany(p => p.Posts)
            //    .HasForeignKey(s => new { s.Title, s.Content })
            //    .HasPrincipalKey(s => s.Id);

            //modelBuilder.Entity<Post>()
            //    .HasMany(p => p.Tags)
            //    .WithMany(b => b.Posts)
            //    .UsingEntity(J => J.ToTable("PostTagsTest"));


            modelBuilder.Entity<Post>()
                .HasMany(p => p.Tags)
                .WithMany(t => t.Posts)
                .UsingEntity<PostTag>
               (
                    j => j.HasOne(pt => pt.Tag)
                .WithMany(t => t.PostTags)
                .HasForeignKey(pt => pt.TagId),
                        j => j
                        .HasOne(pt => pt.Post)
                      .WithMany(p => p.PostTags)
                    .HasForeignKey(pt => pt.PostId),
                 j =>
               {
                    j.HasKey(t => new { t.PostId, t.TagId });
               }
              );



        }
        public DbSet<Blog> Blogs { get; set; }  
        public DbSet<Post> Posts { get; set; }  

        public DbSet<Tag> Tags { get; set; }
        //public DbSet<BlogImage> BlogImages { get; set; }    
    }
    public class Blog
    {
        public int Id { get; set; }
        public string? URL { get; set; }

        //public BlogImage BlogImage { get; set; }
        public List<Post>? Posts { get; set; }


    }
    //public class BlogImage
    //{
    //    public int Id { get; set; }
    //    public string Image {  get; set; }  
    //    [Required, MaxLength(100)]

    //    public string Caption  { get; set; }

    //    public int BlogFK { get; set; } 

    //    public Blog Blog { get; set; }
    //}
    public class Post
    {
        public int PostId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }

        public int BlogId { get; set; }
         public Blog? Blog { get; set; }

        public ICollection<Tag> Tags { get; set; }  
        public List<PostTag> PostTags { get; set; }
    }
    public class Tag
    {
        public string TagId { get; set; }
         public ICollection<Post> Posts { get; set; }
        public List<PostTag> PostTags { get; set; }

    }

    public class PostTag
    {
        public int PostId { get; set;}

        public Post Post { get; set; }
        public string TagId { get; set; }  

        public Tag Tag { get; set; }
        public DateTime? Date { get; set; } 
    }
}
