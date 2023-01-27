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
            _accountCod = accountCod; //this._code = code; normalmete aparece con this
            _accountHolder = accountHolder;
            _accountQuantity = accountquantity;

        }

        //Funcion getname
        public string GetName()
        {
            return _accountHolder;
        }

        //Funcion setname
        public void SetName(string accountHolder) //set utilizan boid porque no devuelven nada
        {
            Name = accountHolder; //tambien se puede utilizar el this aqui
        }

        //Account a = new Account();
        //a.SetName("Juan");
        //a.Name = "Juan"; orientado a java

        //Propiertie publica name
        public string Name { get { return _accountHolder; } set { _accountHolder = value; } } // get => return _username

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
        public double IngressQuantity(double Quantity)//metodos de objeto porque van destinados a cada cuenta, y que no tenga static
        {
            if (Quantity > 0.0)
                _accountQuantity += Quantity;
            return _accountQuantity;//esto no estaba escrito, y seria void si esto se quita
        }

        //Funcion removequantity
        public double RemoveQuantity(double Quantity)//double q
        {
            _accountQuantity -= Quantity;

            if (_accountQuantity < 0.0)
                _accountQuantity = 0.0;
            return _accountQuantity;
        }

        //double result= _quantity _q;
        //if  (_quantity < 0)
        //double aux=-quantity
        //
        //if (q < 0.0)
        // return 0.0;

        //metodo tostring
        public override string ToString()
        {
            return string.Format("IdAccount: {0}, User: {1}, Quantity: {2}", AccountCode, Name, AccountQuantity);
            //return json.serialize(this);
        }

    }
     
}
