using System;
using System.Diagnostics;using System.IO;

namespace DES
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ключевое слово 1: ");
            string keyWord1 = Console.ReadLine();

            Console.WriteLine("Ключевое слово 2: ");
            string keyWord2 = Console.ReadLine();

            Console.WriteLine("Ключевое слово 3: ");
            string keyWord3 = Console.ReadLine();

            DES.Encrypt(keyWord1, keyWord2, keyWord3);
            //DES.Encrypt(keyWord1);
            DES.Decrypt(DES.decodeKey, DES.decodeKey2, DES.decodeKey3);
        }
    }
}
