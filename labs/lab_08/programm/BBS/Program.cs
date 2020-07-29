using System;
using System.Text;

namespace lab_08
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for(; ; )
            {
                // enter 9 14 5 14 10
                try
                {
                    Console.WriteLine("Enter p: ");
                long p = long.Parse(Console.ReadLine());

                Console.WriteLine("Enter q: ");
                long q = long.Parse(Console.ReadLine());

                Console.WriteLine("Enter e: ");
                long e = long.Parse(Console.ReadLine());


                Console.WriteLine("Enter x0: ");
                long x0 = long.Parse(Console.ReadLine());

                Console.WriteLine("Enter the number of elememts in the sequence: ");
                int num = int.Parse(Console.ReadLine());

                
                    RSA sequence = new RSA(p, q, e, x0);
                    Console.WriteLine("Generated num sequence: ");
                    for (int i = 0; i < num; i++)
                    {
                        Console.Write(sequence.getRandNum() + " ");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }


                Console.WriteLine();
                Console.WriteLine();

                //////////////////////////////

                byte[] key = { 76, 111, 85, 54, 211 };

                DateTime start1 = DateTime.Now;
                RC4 encoder = new RC4(key);
                string testString = "Khramykh Vladislav Olegovitch";
                Console.WriteLine("Source string: " + testString);
                byte[] testBytes = ASCIIEncoding.ASCII.GetBytes(testString);
                byte[] result = encoder.Encode(testBytes, testBytes.Length);
                    
                string hexresult = "";
                foreach (byte bt in result)
                {
                    hexresult += Convert.ToString(bt, 16);

                }
                Console.WriteLine("Encoded string: " + hexresult);
                TimeSpan procTime1 = DateTime.Now - start1;
                Console.WriteLine("Ecnryption execution time: " + procTime1.TotalSeconds.ToString() + " sec");

                DateTime start2 = DateTime.Now;
                RC4 decoder = new RC4(key);
                byte[] decryptedBytes = decoder.Decode(result, result.Length);
                string decryptedString = ASCIIEncoding.ASCII.GetString(decryptedBytes);
                Console.WriteLine("Decrypted string: " + decryptedString);
                TimeSpan procTime2 = DateTime.Now - start2;
                Console.WriteLine("Decryption execution time: " + procTime2.TotalSeconds.ToString() + " sec");
            }
           
        }
    }
}
