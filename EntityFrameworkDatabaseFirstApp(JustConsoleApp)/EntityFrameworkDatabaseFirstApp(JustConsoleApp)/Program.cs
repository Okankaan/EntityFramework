using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDatabaseFirstApp_JustConsoleApp_
{
    class Program
    {
        static void Main(string[] args)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();
            //var category = db.Categories.Find(1); //Lazy Loading = True of my NortWindModel.edmx[Diagram]

            var category = db.Categories.Include("Products") //Lazy Loading = False of my NortWindModel.edmx[Diagram]
                .Include("Products.Supplier").               //When Lazy Loading = False mean Eager Loading is True
                FirstOrDefault(x => x.CategoryID == 1);      //Eager Loading used for just one request sending to DB.

            var products = category.Products;
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Supplier.ContactName);

            }
            Console.ReadLine();
        }
    }
}
