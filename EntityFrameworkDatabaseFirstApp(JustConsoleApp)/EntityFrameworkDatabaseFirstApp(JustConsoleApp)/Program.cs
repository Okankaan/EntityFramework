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
            //Single() method using for only if we are sure DB will return a result. If DB return more than 1 result or DB is not return any product, we get Error. 
            //SingleOrDefault() method using for only if we are sure DB will return a result. If DB return more than 1 result, we get Error. If there is no any result of DB Table, DB return null param, it is not return Error.
            //First() method using for if we are sure DB will return a result or more than 1 result. If there is no any result of DB Table, DB return null param, it is not return Error.
            //FirstOrDefault() method using for get First item result of DB Table. With this method, we can not get any Error.
            NORTHWNDEntities db = new NORTHWNDEntities();
            //var result = db.Products.Single(x => x.CategoryID == 1); //This Single() method return us Error. Because DB return more than 1 result.
            //var result = db.Products.SingleOrDefault(x => x.CategoryID == 1); //This SingleOrDefault() method return us Error. Because DB return more than 1 result.
            //var result = db.Products.First(x => x.CategoryID == 1); //This First() method return us First data of CategoryID=1. If DB is not return ant result, It get Error.
            var result = db.Products.FirstOrDefault(x => x.CategoryID == 1); //This FirstOrDefault() method return us First data of CategoryID=1. With this method, we can not get any Error.
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
