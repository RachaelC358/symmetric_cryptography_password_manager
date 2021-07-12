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
    public partial class encryptAndDecrypt
    {
        //
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
        public static string encryptText(string userName, string passWord)
        {
            // find bytes of passWord string
            byte[] bytesToEncrypt = UTF8Encoding.UTF8.GetBytes(passWord);

            // Compute hash value
            MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();
            // Get the specific user key using "generateUserKey" function.
            string customKey = generateUserKey(userName);
            // Pass security key to get hash value.
            byte[] customKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(customKey));
            objMD5CryptoService.Clear();

            var objTripleDES = new TripleDESCryptoServiceProvider();
            objTripleDES.Key = customKeyArray;
            objTripleDES.Mode = CipherMode.ECB;
            objTripleDES.Padding = PaddingMode.PKCS7;

            var crypto = objTripleDES.CreateEncryptor();
            byte[] encryptedBytes = crypto.TransformFinalBlock(bytesToEncrypt, 0, bytesToEncrypt.Length);

            objTripleDES.Clear();
            return Convert.ToBase64String(encryptedBytes,0,encryptedBytes.Length);
        }



        public static string decryptText(string userName, string encryption)
        {
            // find bytes of passWord string
            byte[] bytesToEncrypt = Convert.FromBase64String(encryption);

            // Compute hash value
            MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();
            // Get the specific user key using "generateUserKey" function.
            string customKey = generateUserKey(userName);
            // Pass security key to get hash value.
            byte[] customKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(customKey));
            objMD5CryptoService.Clear();

            var objTripleDES = new TripleDESCryptoServiceProvider();
            objTripleDES.Key = customKeyArray;
            objTripleDES.Mode = CipherMode.ECB;
            objTripleDES.Padding = PaddingMode.PKCS7;

            var crypto = objTripleDES.CreateDecryptor();
            byte[] encryptedBytes = crypto.TransformFinalBlock(bytesToEncrypt, 0, bytesToEncrypt.Length);

            objTripleDES.Clear();
            return UTF8Encoding.UTF8.GetString(encryptedBytes);
        }

    }
}
