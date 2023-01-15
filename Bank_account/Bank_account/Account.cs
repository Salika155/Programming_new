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
            return _accountHolder;
        }

        //Funcion setname
        public void SetName(string accountHolder)
        {
            Name = accountHolder;
        }

        //Propiertie publica name
        public string Name { get { return _accountHolder; } set { _accountHolder = value; } }

        //Funcion getquantity
        public double GetQuantity()
        {
            return _accountQuantity;
        }

        //propiertie publica quantity
        public double AccountQuantity { get { return _accountQuantity; } }

        //propierty publica accountcode
        public string AccountCode { get { return _accountCod; } }

        //Funcion ingressquantity
        public double IngressQuantity(double Quantity)
        {
            if (Quantity > 0)
                _accountQuantity += Quantity;
            return _accountQuantity;
        }

        //Funcion removequantity
        public double RemoveQuantity(double Quantity)
        {
            _accountQuantity -= Quantity;

            if (_accountQuantity < 0)
                _accountQuantity = 0;
            return _accountQuantity;
        }

        //metodo tostring
        public override string ToString()
        {
            return string.Format("IdAccount: {0}, User: {1}, Quantity: {2}", AccountCode, Name, AccountQuantity);
        }

    }
     
}
