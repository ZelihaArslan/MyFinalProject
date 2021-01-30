using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //global değişkenler alt çizgi ile gösterilir.
        public InMemoryProductDal()
        {
            //Oracle,Sql server, postgres,mongodb
            _products = new List<Product> {
               new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitInStock=15},
               new Product{ProductId=2, CategoryId=2, ProductName="Kamera", UnitPrice=500, UnitInStock=3},
               new Product{ProductId=3, CategoryId=3, ProductName="Telefon", UnitPrice=1500, UnitInStock=2},
               new Product{ProductId=4, CategoryId=4, ProductName="Klavye", UnitPrice=150, UnitInStock=65},
               new Product{ProductId=5, CategoryId=5, ProductName="Fare", UnitPrice=85, UnitInStock=1},
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ ile liste bazlı yapıları filtreleyebiliriz.
            //Lambda =>foreach işlemini yapıyor
            //LİNQ =language integrated query

            /*
            foreach (var p in _products)
            {
                if(product.ProductId == p.ProductId)
                {
                    productToDelete = p;
                }
            } */

           Product productToDelete = _products.SingleOrDefault(p=>p.ProductId ==product.ProductId);
            //tek bir eleman bulmaya yarar 
            //her p için bak benim productid me eşit mi


            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün Id sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitInStock = product.UnitInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
        }

       public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();

        }


    }
}
