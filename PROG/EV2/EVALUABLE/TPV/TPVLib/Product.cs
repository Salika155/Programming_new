using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVLib
{
    //public class TicketHeader
    //{
    //    public long Id { get; set; }
    //    public string Barcode { get; set; }

    //}

    //public class TicketLine
    //{
    //    public string Details { get; set; }
    //    public double Quantity { get; set; }
    //    public Product Product;
    //}
    //public class TicketBody
    //{
    //    TicketLine[] Lines;
    //}

    //public class Ticket
    //{
    //    public TicketHeader Header { get; set; }
    //    public List<TicketBody> Body { get; set; }
    //    public double TotalPrize { get; set; }

    //}

    //MODELO DE DATOS
    //crear un idatabase y funciones como AddTicketHeader, AddTicketLine
    //la base de datos tiene que ser simple y que sea otro el que añada las cosas
    //MODELO DE NEGOCIO -> ITPV -> addTicket(Ticket ticket)

    public enum TaxesType
    {
        IVA_4,
        IVA_10,
        IVA_21,
        IVA_0,
    }

    public class Product
    {
       //se trasbaja con properties en c# ademas de que las clases de aplicaciones sean pojo es porque cuando se hace consulta solo devuelve un objeto con las properties, 
       //si tiene variables estas no se devuelven
        public long Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string? Description { get; set; }
        public double IVA { get; set; }
        public TaxesType Type { get; set; }

        public Product()
        {
            Id = 0;
            Name = "";
            Price = 0;
            Stock = 0;
            Description = "";
            IVA = 0;
            Type = TaxesType.IVA_21;
        }


        public Product Clone()
        {
            return new Product
            {
                Id = Id,
                Name = Name,
                Price = Price,
                Stock = Stock,
                Description = "",
                IVA = IVA,
                Type = Type
            };

            //Product product = new Product();
            //product.Id = Id;
            //product.Name = Name;
            //product.Price = Price;
            //product.Stock = Stock;
            //product.Description = "";
            //return product;
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
