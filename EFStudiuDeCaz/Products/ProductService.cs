﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudiuDeCaz.Products
{
    
    public class ProductService
    {
        private readonly ProductContext context;
        public ProductService(ProductContext context)
        {
            this.context = context;
        }

        public void Init()
        {
            var product = new Product
            {
                SKU = 147,
                Description = "Expandable Hydration Pack",
                Price = 19.97M,
                ImageURL = "/pack147.jpg"
            };
            context.Products.Add(product);
            product = new Product
            {
                SKU = 178,
                Description = "Rugged Ranger Duffel Bag",
                Price = 39.97M,
                ImageURL = "/pack178.jpg"
            };
            context.Products.Add(product);
            product = new Product
            {
                SKU = 186,
                Description = "Range Field Pack",
                Price = 98.97M,
                ImageURL = "/noimage.jp"
            };
            context.Products.Add(product);
            product = new Product
            {
                SKU = 202,
                Description = "Small Deployment Back Pack",
                Price = 29.97M,
                ImageURL = "/pack202.jpg"
            };
            context.Products.Add(product);
            context.SaveChanges();

        }

        public void PrintAll()
        {
            foreach (var p in context.Products)
            {
                Console.WriteLine("{0} {1} {2} {3}", p.SKU, p.Description,
                p.Price.ToString("C"), p.ImageURL);
            }

        }
    }
}
