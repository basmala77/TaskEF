using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp2.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Blog blog { get; set; }
    }
}