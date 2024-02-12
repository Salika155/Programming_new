using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVLib
{
    public class Product
    {
       
        public long Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string? Description { get; set; }


        public Product Clone()
        {
            Product product = new Product();
            product.Id = Id;
            product.Name = Name;
            product.Price = Price;
            product.Stock = Stock;
            product.Description = "";
            return product;
        }

        //public Product(long id, string name, double price, int stock)
        //{
        //    Id = id;
        //    Name = name;
        //    Price = price;
        //    Stock = stock;
        //    Description = "";
        //}

    }
}
