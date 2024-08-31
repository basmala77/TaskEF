using ConsoleApp2.Models;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var c = new ApplicationDbContext();
           // var b = new author
           // {
           //     FName = "beso",
           //     Lname = "Test",
           // };
           //c.authors.Add(b);

     
           var cc = new Category { Name = "Test 1" };
           c.Categories.Add(cc);
            c.SaveChanges();
        }
    }
}
