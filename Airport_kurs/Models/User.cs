﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
            this.Username = username;
            this.Password = PassToHashString(password);
            this.AccessLvl = access;
        }



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