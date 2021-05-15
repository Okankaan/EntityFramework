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
            //ThenBy() method using for instead of 2 different OrderBy() method.
            //We can not using 2 OrderBy() method, if we use 2 OrderBy() methods, just second OrderBy() method running, first OrderBy() method is not run.
            NORTHWNDEntities db = new NORTHWNDEntities();
            var products = db.Products
                .OrderBy(x => x.CategoryID) //Order for CategoryID
                /*.OrderBy(x => x.ProductName)*/  //Order for ProductName
                .ThenBy(x => x.ProductName)
                .Select(x => new
                {
                    x.CategoryID,
                    x.ProductName
                });
            ConsoleTable.From(products).Write();
            Console.ReadLine();
        }
    }
}
