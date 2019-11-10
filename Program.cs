using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe
{
    class Category
    {
        public int CategoryID { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public IList<Product> Products { set; get; }

    }

    class Product
    {
        public int ProductID { set; get; }
        public string StringName { set; get; }
        public int UnitsInStock { set; get; }
        public int CategoryID { set; get; }
    }

    class Customer
    {
        [Key]
        public string CompanyName { set; get; }
        public string Description { set; get; }
    }

    class ProdContex : DbContext
    {
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Customer> Customers { set; get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ProdContex context = new ProdContex();

            //string categoryName;
            //Console.Write("Podaj nazwe kategorii ");
            //categoryName = Console.ReadLine();
            //Category category = new Category();
            //category.Name = categoryName;

            //context.Categories.Add(category);
            //context.SaveChanges();

            //IQueryable<string> CatNames = from cat in context.Categories
            //                              orderby cat.Name descending
            //                              select cat.Name;

            //foreach (var item in CatNames)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
