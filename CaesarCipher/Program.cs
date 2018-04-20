using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'à';
            char b = ' ';

            Cipher cipher = new Cipher();
            cipher.Plaintext = "Who are you ? - bạn là ai?";
            cipher.K = 10;
            var str= cipher.Encrypt();
            cipher.Ciphertext = str;
            var text = cipher.Decrypt();
            Console.WriteLine($"Plain Text :{cipher.Plaintext} \n Cipher text :{cipher.Ciphertext} \n Decrypt :{text}");
        }



    }
}
