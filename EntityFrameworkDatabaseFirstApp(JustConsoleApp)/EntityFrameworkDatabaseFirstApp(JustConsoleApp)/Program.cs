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
            foreach (var cat in categories)
            {
                Console.WriteLine(cat.CategoryName);
            }
            Console.ReadLine();
        }
    }
}
