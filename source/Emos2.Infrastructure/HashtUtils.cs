﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure
{
    public static class HashUtils
    {
        public static string Hash(string value)
        {
            HashAlgorithm hashAlgorithm = new SHA256CryptoServiceProvider();

            byte[] valueBytes = Encoding.UTF8.GetBytes(value);
            byte[] hashValueBytes = hashAlgorithm.ComputeHash(valueBytes);

            string hashValue = Convert.ToBase64String(hashValueBytes);

            return hashValue;
        }
    }
}
