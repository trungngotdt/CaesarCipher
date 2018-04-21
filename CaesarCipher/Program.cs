using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Input:");
            string text = Console.ReadLine();
            bool isKey = false;
            int k=0;
            while (isKey==false)
            {
                Console.WriteLine("Key :");
                string key = Console.ReadLine();
                isKey= int.TryParse(key,out k);
            }
            Cipher cipher = new Cipher();
            cipher.Plaintext =text;
            cipher.K = k;
            var str= cipher.Encrypt();
            Console.WriteLine($"Encrypt :{str}");

            cipher.Ciphertext = str;
            var textDeCrypt = cipher.Decrypt();
            
            Console.WriteLine($"Plain Text :{cipher.Plaintext} \n Cipher text :{cipher.Ciphertext} \n Decrypt :{textDeCrypt}");
        }



    }
}
