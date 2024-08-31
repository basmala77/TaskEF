using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class author
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string FName { get; set; }
        [Required,MaxLength(100)]
        public string Lname { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Description { get; set; } 
    }
}
