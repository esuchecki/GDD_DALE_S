// Modulo para encriptar una password con SHA-256.
//
//
//

using System.Security.Cryptography;
using System;
using System.Text;

namespace WindowsFormsApplication1
{
    public static class _SHA256Encrypt
    {
        
        
        public static string encriptar(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }  
       
   
    
    
    }
}

