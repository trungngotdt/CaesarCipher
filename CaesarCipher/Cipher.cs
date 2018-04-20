using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher
{
    public class Cipher
    {
        private string plaintext;

        private int k;

        private string ciphertext;
        public string Plaintext { get => plaintext; set => plaintext = value; }
        public int K { get => k; set => k = value; }
        public string Ciphertext { get => ciphertext; set => ciphertext = value; }

        public Cipher()
        {

        }

        public string Encrypt()
        {
            return Encrypt(Plaintext, K);
        }

        public string Decrypt()
        {
            return Encrypt(Ciphertext, -K);
        }

        private string Encrypt(string plaintext,int key)
        {
            string text = "";
            var listchar = plaintext.ToCharArray();
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < listchar.Length; i++)
            {

                builder.Append(convertChar(listchar[i], key));
            }
            return builder.ToString();
        }

        private char convertChar(char c,int key)
        {
            return (char)((int)c + key);
        }
    }
}
