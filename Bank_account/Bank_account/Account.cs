using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account
{
    public class Account
    {
        private string _accountCod;
        private string _accountHolder;
        private double _accountQuantity;

        //constructor vacío
        public Account()
        {
        }

        //constructor con parámetros
        public Account(string accountCod, string accountHolder, double accountquantity)
        {
            _accountCod = accountCod;
            _accountHolder = accountHolder;
            _accountQuantity = accountquantity;

        }

        //Funcion getname
        public string GetName()
        {
            return Name;
        }

        //Funcion setname
        public void SetName(string accountHolder)
        {
            Name = accountHolder;
        }

        //Propiertie publica name
        public string Name { get; set; }
        
        //Funcion getquantity
        public double GetQuantity()
        {
            return Quantity;
        }
            
        //propiertie publica quantity
        public double Quantity { get; }
        
        //propierty publica accountcode
        public string AccountCode { get; }
        
        //Funcion ingressquantity
        public void IngressQuantity(double Quantity)
        {
            Quantity = _accountQuantity;
        }

        //Funcion removequantity
        public double RemoveQuantity()
        {
            
        }
        double ToString()
    }
}
