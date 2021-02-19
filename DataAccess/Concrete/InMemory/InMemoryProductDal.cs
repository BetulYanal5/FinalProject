﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal :IProductDal
    {
        List<Product> _products;//Global değişken
        public InMemoryProductDal()
        {    
            //Oracle,Sql Server,Postgres,MongoDb'den veri geliyormuş gibi
            _products = new List<Product> { 
             new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
             new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
             new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
             new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
             new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);//Listeye Business dan gelen yeni ürünü ekler
        }

        public void Delete(Product product)
        {   //LINQ - Language Integrated Query ile liste bazlı yapıları sql gibi listeleyebiliyoruz
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            //SingleOrDefault() foreach yapılmasını sağlar,listedeki tüm ürünleri tek tek dolaşır,p takma isimdir
            _products.Remove(product);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()//Veri tabanındaki veri Business a verilir
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
            //where koşulu içindeki şarta uyan bütün elemanları yeni bir liste haline getirir ve döndürür
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)//buradaki ürün kullanıcının ekrandan güncelleyip güncelle butonuna bastığı ürün ve biz bu ürünü veri tabanında güncellemiş olduk
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
