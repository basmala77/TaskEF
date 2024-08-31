using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class book
    {
        public int BookKey { get; set; }
        public string Name { get; set; }
        public string auther { get; set; }  
    }
}
