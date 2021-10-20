using EFDemo.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFDemo
{
    class Program
    {
        public static void Main()
        {
            using (var db = new NorthwindDbContext())
            {
                IQueryable<Category> categories = db.Categories.Include(c => c.Products);

            }
        }
    }
}
