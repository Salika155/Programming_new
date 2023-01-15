using System.Security.Cryptography.X509Certificates;

namespace Bank_account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Account1 = new Account("000001", "Sam Moreno", 1000);
            Console.WriteLine("AccountCode: {0}, AccountHolder: {1}, Quantity: {2}", 
                Account1.accountCod, Account1.accountHolder, Account1.quantity);

         
            
        }
    }
}