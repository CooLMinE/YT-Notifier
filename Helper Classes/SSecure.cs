using System;
using System.Text;

namespace YTNotifier.Helper_Classes
{
    static class SSecure
    {

        public static string Protect(string data)
        {
            return Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(data));
        }

        public static string Unprotect(string data)
        {
            return ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(data));
        }
    }
}
