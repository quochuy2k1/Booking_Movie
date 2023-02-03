using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Payment.Momo
{
    public interface IMoMoSecurity
    {
        string getHash(string partnerCode, string merchantRefId,
            string amount, string paymentCode, string storeId, string storeName, string publicKeyXML);
        string buildQueryHash(string partnerCode, string merchantRefId,
           string requestid, string publicKey);
        string buildRefundHash(string partnerCode, string merchantRefId,
            string momoTranId, long amount, string description, string publicKey);
        string signSHA256(string message, string key);
    }
}
