using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //oPEN cLOSED Principle : yaptıgın yazılıma yeni bir özellik ekliyorsan mevcuttaki hiç bir koduna dokunamazsın 
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAll()) 
            {
                Console.WriteLine(product.ProductName);

            }

           
        }
    }
}
