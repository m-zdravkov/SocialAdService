using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Model;

namespace BusinessTier
{
    public static class SecureHashingControl
    {
        /// <summary>
        /// Generates a hashed password + salt for a User object.
        /// </summary>
        /// <returns>The generated password hash in byte[]</returns>
        public static byte[] GeneratePassword(this User user, string password)
        {
            var salt = GenerateSalt(256);
            user.Salt = salt;
            user.PasswordHash = GenerateSHA256Password(password, salt);

            return user.PasswordHash;
        }

        /// <summary>
        /// Generates a hashed password from an existing salt for a User object.
        /// Used to match existing passwords.
        /// </summary>
        /// <returns>The generated password hash in byte[]</returns>
        public static bool MatchPassword(this User user, string password, byte[] salt, byte[] passwordHash)
        {
            user.Salt = salt;
            user.PasswordHash = GenerateSHA256Password(password, salt);

            return user.PasswordHash.Equals(passwordHash);
        }
        
        /// <summary>
        /// Generates a password using SHA-256
        /// </summary>
        /// <returns></returns>
        private static byte[] GenerateSHA256Password(string text, byte[] salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            bytes.Concat(salt);

            byte[] hash;

            using (SHA256Managed sha256 = new SHA256Managed())
            {
                hash = sha256.ComputeHash(bytes);
            }
            return hash;
        }

        public static byte[] GenerateSalt(int length)
        {
            var salt = new byte[length];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetNonZeroBytes(salt);
            }

            return salt;
        }
    }
}
