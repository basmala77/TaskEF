using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string URL { get; set; }
        //public BlogImage BlogImage { get; set; }    
        public List<Post> Posts { get; set; }   

    }
    public class Postt
    {
        public int id
        { get; set; }   
        public string title { get; set; }
        public string description { get; set; }
        public Blog Blog { get; set; }  
    }
    public class BlogImage
    { public int Id { get; set; }
      public string Image {  get; set; }
        [Required,MaxLength(255)]
        public string Title { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
