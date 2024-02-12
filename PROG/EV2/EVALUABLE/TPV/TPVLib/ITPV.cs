

using System.Security.Cryptography.X509Certificates;

namespace TPVLib
{
    public interface ITPV
    {
        static ITPV CreateNewTPV()
        {
            RAMTPV rAMTPV = new RAMTPV();
            return rAMTPV;
        }

        public static void AddProduct(Product product)
        {
           
        }

        //hay que hacer el add product
    }
}
