using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Airport_kurs.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int AccessLvl { get; set; }

        public static string PassToHashString(string pass)
        {
            byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] byteArr = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

            int i;
            StringBuilder sOutput = new StringBuilder(byteArr.Length);
            for (i = 0; i < byteArr.Length; i++)
            {
                sOutput.Append(byteArr[i].ToString("X2"));
            }
            return sOutput.ToString();
        }

        public bool ComparisonHash(string hash)
        {
            return this.Password == hash;
        }
    }
}
