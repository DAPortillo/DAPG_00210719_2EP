using System;
using System.Security.Cryptography;
using System.Text;

namespace SourceCode
{
    public static class Encripter
    {
        public static string CreateMD5(string input)
                {
                    // Use input string to calculate MD5 hash
                    using (MD5 md5 = MD5.Create())
                    {
                        byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                        byte[] hashBytes = md5.ComputeHash(inputBytes);
        
                        // Convert the byte array to hexadecimal string
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < hashBytes.Length; i++)
                        {
                            sb.Append(hashBytes[i].ToString("x2"));
                        }
        
                        return sb.ToString();
                    }
                }
        
                public static bool CompareMD5(string chain, string pMD5)
                {
                    // Hash the input.
                    string hashOfInput = CreateMD5(chain);
        
                    // Create a StringComparer an compare the hashes.
                    StringComparer comparer = StringComparer.OrdinalIgnoreCase;
        
                    return (0 == comparer.Compare(hashOfInput, pMD5));
                }
    }
}