using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace agency_csharp
{
    class PasswordEncrypt
    {
        public static string HashPassword(string password)
        {
            MD5 md = MD5.Create();

            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = md.ComputeHash(b);

            StringBuilder sb = new StringBuilder();

            foreach (var a in hash)
            {
                sb.Append(a.ToString("X2"));
            }

            return Convert.ToString(sb);
        }
    }
}
