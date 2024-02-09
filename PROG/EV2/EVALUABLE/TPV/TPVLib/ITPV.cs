

namespace TPVLib
{
    public interface ITPV
    {
        static ITPV CreateNewTPV()
        {
            return new RAMTPV();
        }

        //hay que hacer el add product
    }
}
