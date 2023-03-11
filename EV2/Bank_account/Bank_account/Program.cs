using System.Security.Cryptography.X509Certificates;

namespace Bank_account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Account1 = new Account("001", "John Doe", 100);
            Console.WriteLine("Numero Cuenta: {0}, Usuario: {1}, Cantidad: {2}", 
                Account1.AccountCode, Account1.Name, Account1.AccountQuantity);

            Account Account2 = new Account("002", "Janette Doe", 500);
            Console.WriteLine("Numero Cuenta: {0}, Usuario: {1}, Cantidad: {2}",
                Account2.AccountCode, Account2.Name, Account2.AccountQuantity);

            
            Console.WriteLine("Depositar 70€ en cuenta1");
            Account1.IngressQuantity(70);
            Console.WriteLine(Account1.AccountQuantity);
            
            Console.WriteLine("Retirar 200€ en cuenta2");
            Account2.RemoveQuantity(200);
            Console.WriteLine(Account2.AccountQuantity);

            Console.WriteLine(Account1.ToString());
            Console.WriteLine(Account2.ToString());

        }
    }
}