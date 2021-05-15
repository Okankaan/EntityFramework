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
            //Skip(n) method using for Skip and don't get the first n piece of the result set you found.
            //Take(n) method using for Take and get first n piece of the result set of after Skipping n piece result.
            NORTHWNDEntities db = new NORTHWNDEntities();
            var products = db.Products
                .OrderBy(x => x.CategoryID) //Order for CategoryID
                .Skip(12) //Skip and don't get the first 12 of the result set you found.(Bulduğun sonuç kümesinden ilk 12 tanesini atla, gösterme.) 
                .Take(5) //Take and get first 5 of the result set of after Skipping 12 result.(Atlanan 12 üründen sonra gelen ilk 5 ürünü al ve göster.) 
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
