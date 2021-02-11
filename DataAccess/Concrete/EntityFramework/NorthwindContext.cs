using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tabloları ile proje classlarını bağlamak

   public class NorthwindContext:DbContext
    {
        //bu metot hangi veri tabanı ile ilşkili onu gösterecek
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        //Trusted_Connection: kullanıcı adı gerektirmeden domain yönetiminin zayıf oldugu 
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
