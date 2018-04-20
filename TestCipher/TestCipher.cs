using FizzWare.NBuilder;
using NUnit.Framework;
using System.Collections;
using System.Linq;
using CaesarCipher;

namespace TestCipher
{
    [TestFixture]
    public class TestCipher
    {
        Cipher cipher;
        string[] plaintext;
        [SetUp]
        public void SetUp()
        {
            cipher = new Cipher();
            var generator = new RandomGenerator();
            plaintext = Enumerable.Range(0, 10).Select(el => generator.Phrase(10)).ToArray();
        }

        [Test]
        public void Test()
        {
            for (int i = 0; i < plaintext.Length; i++)
            {
                var text = plaintext[i];
                cipher.Plaintext = text;
                cipher.K = i;
                cipher.Ciphertext = cipher.Encrypt();
                var result = cipher.Decrypt();
                Assert.IsTrue(text.Equals( result));
            }
        }
    }
}
