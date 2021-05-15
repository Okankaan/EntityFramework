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
            //All() method using for All DB data sets(return true or false)
            //Any() method using for Any DB data sets(return true or false)
            //Any() methodu genellikle Login işlemlerinde, böyle bir kullanıcı var mı? şeklinde kullanıyoruz.
            NORTHWNDEntities db = new NORTHWNDEntities();
            //var result = db.Products.All(x=>x.UnitPrice>0); //If UnitPrice > 0 of my All Products return true.
            var result = db.Products.Any(x => x.UnitPrice > 0); //If UnitPrice > 0 of my Any Products return true.
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
