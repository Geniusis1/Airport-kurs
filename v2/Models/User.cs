using System.Security.Cryptography;
using System.Text;

namespace Airport_kurs.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int AccessLvl { get; set; }

        public User()
        {
            Username = "null";
            Password = PassToHashString("null");
            AccessLvl = 0;
        }

        public User(string username, string password, int access)
        {
            Username = username;
			Password = PassToHashString(password);
            AccessLvl = access;
        }

        //Хеширование пароля
        public static string PassToHashString(string pass)
        {
            byte[] tmpSource = Encoding.ASCII.GetBytes(pass);
            byte[] byteArr = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

            int i;
            StringBuilder sOutput = new StringBuilder(byteArr.Length);
            for (i = 0; i < byteArr.Length; i++)
            {
                sOutput.Append(byteArr[i].ToString("X2"));
            }
            return sOutput.ToString();
        }

        //Сравнение Хешей
        public bool ComparisonHash(string hash)
        {
            return this.Password == hash;
        }
    }
}
