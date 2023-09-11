using SalesAPI.Data;
using SalesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace SalesAPI.UserRepository
{
    public class UserRepo : IDisposable
    {
        ApplicationDBContext dbContext = new ApplicationDBContext();
        


        public s_User ValidateUser(string LoginName, string Password) {
            string hashedPassword = HashPassword(Password);
            return dbContext.s_User.FirstOrDefault(s_user => s_user.u_LoginName.Equals(LoginName, StringComparison.OrdinalIgnoreCase)
            && s_user.u_Password == hashedPassword);
            //CalculateMD5Hash(Password));

        
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }


        public string HashPassword(string input)
        {
            // step 1, calculate MD5 hash from input
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        static string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2")); // Convert byte to hexadecimal
                }

                return builder.ToString();
            }
        }







    }
}