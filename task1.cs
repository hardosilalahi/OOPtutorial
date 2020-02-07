using System;
using System.Security.Cryptography;
using System.Text;


namespace classtutorial
{
    public class Hancok
    {

        public string md5Hash(string rawData)  
        {  
            using (MD5 md5Hash = MD5.Create())  
            {  
                byte[] bytes = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));  
  
                StringBuilder builder = new StringBuilder();  
                for (int i = 0; i < bytes.Length; i++)  
                {  
                    builder.Append(bytes[i].ToString("x2"));  
                }  
                return builder.ToString();  
            }  
        }

        public string Sha1Hash(string rawData)  
        {  
            using (SHA1 sha1Hash = SHA1.Create())  
            {  
                byte[] bytes = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));  
  
                StringBuilder builder = new StringBuilder();  
                for (int i = 0; i < bytes.Length; i++)  
                {  
                    builder.Append(bytes[i].ToString("x2"));  
                }  
                return builder.ToString();  
            }  
        }

        public string Sha256Hash(string rawData)  
        {  
            using (SHA256 sha256Hash = SHA256.Create())  
            {  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));  
  
                StringBuilder builder = new StringBuilder();  
                for (int i = 0; i < bytes.Length; i++)  
                {  
                    builder.Append(bytes[i].ToString("x2"));  
                }  
                return builder.ToString();  
            }  
        }

        public string Sha512Hash(string rawData)  
        {  
            using (SHA512 sha512Hash = SHA512.Create())  
            {  
                byte[] bytes = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));  
  
                StringBuilder builder = new StringBuilder();  
                for (int i = 0; i < bytes.Length; i++)  
                {  
                    builder.Append(bytes[i].ToString("x2"));  
                }  
                return builder.ToString();  
            }  
        }
    }
}