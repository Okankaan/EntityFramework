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

            /*select ProductName, CategoryName from Categories 
            join Products on Categories.CategoryID=Products.CategoryID*/
            /*var result = from c in db.Categories
                         join p in db.Products
                         on c.CategoryID equals p.CategoryID
                         select new
                         {
                             p.ProductName,
                             c.CategoryName
                         };*///  -> LINQ format writing

            /*select ProductName, CategoryName, UnitPrice from Categories 
            join Products on Categories.CategoryID=Products.CategoryID
            order by UnitPrice desc*/
            /*var result = from c in db.Categories
                         join p in db.Products
                         on c.CategoryID equals p.CategoryID
                         orderby p.UnitPrice descending
                         select new
                         {
                             p.ProductName,
                             c.CategoryName,
                             p.UnitPrice
                         };*///  -> LINQ format writing

            /*select CategoryID, COUNT(*) as NumberOfProducts from Products
             group by CategoryID*/
            /*var result = from p in db.Products
                         group p by p.CategoryID into g
                         select new
                         {
                             g.Key,
                             NumberOfProducts = g.Count()
                         };*///  -> LINQ format writing

            /*select CategoryID, COUNT(*) as NumberOfProducts from Categories
             join Products on Categories.CategoryID=Products.CategoryID
             group by CategoryName*/
            /*var result = from p in db.Products
                         join c in db.Categories
                         on p.CategoryID equals c.CategoryID
                         group c by c.CategoryName into g
                         select new
                         {
                             g.Key,
                             NumberOfProducts = g.Count()
                         };*///  -> LINQ format writing

            /*select CategoryName, COUNT(*) as NumberOfProducts
             SUM(UnitPrice) as TotalPrice,
             MAX(UnitPrice) MaxPrice,
             MIN(UnitPrice) MinPrice
             from Categories
             join Products on Categories.CategoryID=Products.CategoryID
             group by CategoryName*/
            /*var result = from p in db.Products
                         join c in db.Categories
                         on p.CategoryID equals c.CategoryID
                         group new { c, p } by new { c.CategoryName } into g
                         select new
                         {
                             g.Key.CategoryName,
                             NumberOfProducts = g.Count(),
                             TotalPrice = g.Sum(x => x.p.UnitPrice),
                             MaxPrice = g.Max(x => x.p.UnitPrice),
                             MinPrice = g.Min(x => x.p.UnitPrice)
                         };*///  -> LINQ format writing

            /*select CategoryName, COUNT(*) as NumberOfProducts
            SUM(UnitPrice) as TotalPrice,
            MAX(UnitPrice) MaxPrice,
            MIN(UnitPrice) MinPrice
            from Categories
            join Products on Categories.CategoryID=Products.CategoryID
            group by CategoryName
            having SUM(UnitPrice)>300*/
            var result = (from p in db.Products
                         join c in db.Categories
                         on p.CategoryID equals c.CategoryID
                         group new { c, p } by new { c.CategoryName } into g
                         select new
                         {
                             g.Key.CategoryName,
                             NumberOfProducts = g.Count(),
                             TotalPrice = g.Sum(x => x.p.UnitPrice),
                             MaxPrice = g.Max(x => x.p.UnitPrice),
                             MinPrice = g.Min(x => x.p.UnitPrice)
                         }).Where(x=>x.TotalPrice>300);//  -> LINQ format writing
            ConsoleTable.From(result).Write();
            Console.ReadLine();
        }
    }
}
