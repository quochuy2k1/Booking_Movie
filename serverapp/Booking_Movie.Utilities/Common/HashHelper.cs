using System.Security.Cryptography;
using System.Text;

namespace Booking_Movie.Utilities.Common
{
    public static class HashHelper
    {
        public static string HmacSha256(string text, string key)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();

            byte[] textBytes = encoding.GetBytes(text);
            byte[] keyBytes = encoding.GetBytes(key);

            byte[] hashBytes;

            using (HMACSHA256 hash = new HMACSHA256(keyBytes))
                hashBytes = hash.ComputeHash(textBytes);

            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }

        public static bool VerifyCallback(string data, string qrSerect, string requestMac)
        {
            try
            {
                string mac = HmacSha256(data, qrSerect);

                return requestMac.Equals(mac);
            }
            catch
            {
                return false;
            }
        }

        public static string PasswordHash(string password, string salt)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password, salt, true, BCrypt.Net.HashType.SHA256);
            return passwordHash;
        }

        public static bool VerifyPasswordHash(string password, string passwordHash)
        {
            bool Password = BCrypt.Net.BCrypt.Verify(password, passwordHash, true, BCrypt.Net.HashType.SHA256);
            return Password;
        }
    }
}