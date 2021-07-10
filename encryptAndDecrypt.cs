using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

// This file contains fucntions for encryption, decryption, and 
// generation of user-specific keys.

namespace CarpenterPass
{
    class encryptAndDecrypt
    {

        public static string hashUserNameForKey(string userName, string salt, HashAlgorithm hasherHash)
        {
            byte[] saltByteText = Encoding.UTF8.GetBytes(string.Concat(userName, salt));
            byte[] byteHash = hasherHash.ComputeHash(saltByteText);
            hasherHash.Clear();

            return Convert.ToBase64String(byteHash);
        }

        // each user needs a user specific key 
        // This function will take a username and generate a key.
        // This is a one-way hash
        public static string generateUserKey(string userName)
        {
            string salt = "ultraSecretSalt39756";
            string userKey = hashUserNameForKey(userName, salt, new SHA1CryptoServiceProvider());

            return userKey;
        }


        // Use this method to convert password text to encrypted text.
        public static string encryptText(string passWord)
        { 
            // find bytes of passWord string


        }


    }
}
