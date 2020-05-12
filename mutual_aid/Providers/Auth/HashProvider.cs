using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace mutual_aid.Providers.Auth
{
    public class HashProvider
    {
        private const int WorkFactor = 10000;

        public HashedPassword HashPassword(string plainTextPassword)
        {
            //Create the hashing provider
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(plainTextPassword, 8, WorkFactor);

            //Get the Hashed Password
            byte[] hash = rfc.GetBytes(20);

            //Set the SaltValue 
            string salt = Convert.ToBase64String(rfc.Salt);

            //Return the Hashed Password
            return new HashedPassword(Convert.ToBase64String(hash), salt);
        }

        public bool VerifyPasswordMatch(string existingHashedPassword, string plainTextPassword, string salt)
        {
            byte[] saltArray = Convert.FromBase64String(salt);      //gets us the byte[] array representation

            //Create the hashing provider
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(plainTextPassword, saltArray, WorkFactor);

            //Get the hashed password
            byte[] hash = rfc.GetBytes(20);

            //Compare the hashed password values
            string newHashedPassword = Convert.ToBase64String(hash);

            return (existingHashedPassword == newHashedPassword);
        }
    }

    public class HashedPassword
    {
        /// Creates a new hashed password.
        public HashedPassword(string password, string salt)
        {
            this.Password = password;
            this.Salt = salt;
        }

        /// The hashed password
        public string Password { get; }

        /// The salt used to get the hashed password.
        public string Salt { get; }
    }
}
