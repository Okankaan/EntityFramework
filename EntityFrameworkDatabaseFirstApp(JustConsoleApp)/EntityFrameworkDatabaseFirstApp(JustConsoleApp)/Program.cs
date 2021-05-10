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
            var categories = db.Categories;
            Console.WriteLine("\nCategories Outputs from DB:");
            Console.WriteLine("-----------");
            foreach (var cat in categories)
            {
                Console.WriteLine(cat.CategoryName);
            }

            Console.WriteLine("\n____________________________________");
            Console.WriteLine("\nStore Procedure Outputs about Ten Most Expensive Products with its Unit Prices:");
            Console.WriteLine("-----------");
            var products = db.Ten_Most_Expensive_Products();
            foreach (var product in products)
            {
                Console.WriteLine(product.TenMostExpensiveProducts + "/" + product.UnitPrice);
            }

            Console.WriteLine("\n____________________________________");
            Console.WriteLine("\nStore Procedure Outputs about Sales By Year from 1997 to now:");
            Console.WriteLine("-----------");
            var sales = db.Sales_by_Year(new DateTime(1997,1,1),DateTime.Now);
            foreach (var sale in sales)
            {
                Console.WriteLine(sale.Year + "/" + sale.Subtotal);
            }
            Console.ReadLine();
        }
    }
}
