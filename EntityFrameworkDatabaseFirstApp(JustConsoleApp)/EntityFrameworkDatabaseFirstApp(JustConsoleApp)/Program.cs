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

            //select * from Categories
            //var result = db.Categories; // -> METHOD format writing
            /*var result = from cat in db.Categories
                         select cat;*/ //  -> LINQ format writing

            //select CategoryID as Id, CategoryName as Name from Categories 
            /*var result = db.Categories.Select(x=>new {
                Id=x.CategoryID,
                Name=x.CategoryName
            }); *///  -> METHOD format writing

            /*var result = from cat in db.Categories
                         select new
                         {
                             Id = cat.CategoryID,
                             Name = cat.CategoryName
                         };*/ //  -> LINQ format writing

            //select top(2) * from Categories 
            /*var result = db.Categories.Take(2);*/ //  -> METHOD format writing

            //select * from Categories order by CategoryName
            /*var result = db.Categories.OrderBy(x=>x.CategoryName);*/ //  -> METHOD format writing

            //select * from Categories order by CategoryName desc
            /*var result = db.Categories.OrderByDescending(x => x.CategoryName);*/ //  -> METHOD format writing

            //select * from Categories where CategoryID<5 
            /*var result = db.Categories.Where(x => x.CategoryID<5);*/ //  -> METHOD format writing

            //select * from Categories where CategoryID=1 or CategoryID=3 
            //var result = db.Categories.Where(x => x.CategoryID ==1 || 
            //x.CategoryID==3); //  -> METHOD format writing

            //select SUM(CategoryID) from Categories
            //var result = db.Categories.Sum(x => x.CategoryID); //  -> METHOD format writing
            //Console.WriteLine(result);

            //select AVG(CategoryID) from Categories
            //var result = db.Categories.Average(x => x.CategoryID); //  -> METHOD format writing
            //Console.WriteLine(result);

            //select MAX(CategoryID) from Categories
            //var result = db.Categories.Max(x => x.CategoryID); //  -> METHOD format writing
            //Console.WriteLine(result);

            //select MIN(CategoryID) from Categories
            //var result = db.Categories.Min(x => x.CategoryID); //  -> METHOD format writing
            //Console.WriteLine(result);

            //select CategoryID as Id, CategoryID*CategoryID as IdKare from Categories
            //var result = db.Categories.Select(x => new {
            //    Id=x.CategoryID,
            //    IdKare=x.CategoryID*x.CategoryID
            //}); //  -> METHOD format writing

            //select * from Categories where CategoryName like '%ro%'
            //var result = db.Categories.Where(x => x.CategoryName.Contains("ro")); //  -> METHOD format writing

            //select * from Categories where CategoryName like 'pr%'
            //var result = db.Categories.Where(x => x.CategoryName.StartsWith("pr")); //  -> METHOD format writing

            //select * from Categories where CategoryName like '%ts'
            var result = db.Categories.Where(x => x.CategoryName.EndsWith("ts")); //  -> METHOD format writing
            ConsoleTable.From(result).Write();
            Console.ReadLine();
        }
    }
}
