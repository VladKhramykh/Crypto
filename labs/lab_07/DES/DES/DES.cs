using System;
using System.Diagnostics;using System.IO;

namespace DES
{
    public class DES
    {
        public const int sizeOfBlock = 128; //в DES размер блока 64 бит, но поскольку в unicode символ в два раза длинее, то увеличим блок тоже в два раза
        public const int sizeOfChar = 16; //размер одного символа (in Unicode 2 байта)

        public const int shiftKey = 2; //сдвиг ключа 

        public const int quantityOfRounds = 16; //количество раундов

        public static string[] Blocks; //сами блоки в двоичном формате

        public static string decodeKey;
        public static string decodeKey1;
        public static string decodeKey2;
        public static string decodeKey3;
        public static string encodeKey;
        public static string encodeKey1;
        public static string encodeKey2;
        public static string encodeKey3;

        public static void Encrypt(string key, string key2, string key3)        {            if (key != null && key2 != null && key2 != null)            {
                //инициализация текста и ключа
                string s = "";                string result = "";                StreamReader sr = new StreamReader("in.txt");                while (!sr.EndOfStream)                {                    s += sr.ReadLine();                }                sr.Close();                for(int e = 0; e < 3; e++)
                {
                    if (e == 0)
                    {
                        s = StringToRightLength(s);
                        //строка нарезается на блоки
                        CutStringIntoBlocks(s);

                        key = CorrectKeyWord(key, s.Length / (2 * Blocks.Length));
                        key = StringToBinaryFormat(key);

                        for (int j = 0; j < quantityOfRounds; j++)
                        {
                            for (int i = 0; i < Blocks.Length; i++)
                            {
                                Blocks[i] = EncodeDES_One_Round(Blocks[i], key);
                            }

                            key = KeyToNextRound(key);
                        }

                        key = KeyToPrevRound(key);

                        for (int i = 0; i < Blocks.Length; i++)
                        {
                            result += Blocks[i];
                        }

                        s = StringFromBinaryToNormalFormat(result);
                        decodeKey = StringFromBinaryToNormalFormat(key);
                        Console.WriteLine("DecodeKey: " + decodeKey);
                        Console.WriteLine("result: " + StringFromBinaryToNormalFormat(result));
                    }
                    if (e == 1)
                    {
                        s = StringToRightLength(s);
                        //строка нарезается на блоки
                        CutStringIntoBlocks(s);

                        key2 = CorrectKeyWord(key2, s.Length / (2 * Blocks.Length));
                        key2 = StringToBinaryFormat(key2);

                        for (int j = 0; j < quantityOfRounds; j++)
                        {
                            for (int i = 0; i < Blocks.Length; i++)
                            {
                                Blocks[i] = EncodeDES_One_Round(Blocks[i], key2);
                            }

                            key2 = KeyToNextRound(key2);
                        }
                        result = "";
                        for (int i = 0; i < Blocks.Length; i++)
                        {
                            result += Blocks[i];
                        }
                        key2 = KeyToPrevRound(key2);
                        s = StringFromBinaryToNormalFormat(result);
                        decodeKey2 = StringFromBinaryToNormalFormat(key2);
                        Console.WriteLine("DecodeKey2: " + decodeKey2);
                        Console.WriteLine("result: " + StringFromBinaryToNormalFormat(result), System.Text.Encoding.Unicode);
                    }
                    if (e == 2)
                    {                    
                        s = StringToRightLength(s);
                        //строка нарезается на блоки
                        CutStringIntoBlocks(s);

                        key3 = CorrectKeyWord(key3, s.Length / (2 * Blocks.Length));
                        key3 = StringToBinaryFormat(key3);

                        for (int j = 0; j < quantityOfRounds; j++)
                        {
                            for (int i = 0; i < Blocks.Length; i++)
                            {
                                Blocks[i] = EncodeDES_One_Round(Blocks[i], key3);
                            }

                            key3 = KeyToNextRound(key3);
                        }
                        result = "";
                        for (int i = 0; i < Blocks.Length; i++)
                        {
                            result += Blocks[i];
                        }

                        key3 = KeyToPrevRound(key3);

                        decodeKey3 = StringFromBinaryToNormalFormat(key3);
                        Console.WriteLine("DecodeKey3: " + decodeKey3);
                        Console.WriteLine("result: " + StringFromBinaryToNormalFormat(result));
                    }                    
                }                                StreamWriter sw = new StreamWriter("out1.txt", false, System.Text.Encoding.Unicode);                sw.WriteLine(StringFromBinaryToNormalFormat(result));                sw.Close();                Process.Start("out1.txt");            }            else            {                Console.WriteLine("Введите ключевое слово!");            }        }

        public static void Decrypt(string key, string key2, string key3)        {            if (key != null && key2 != null && key3 != null)            {                string s = "";                string result = "";                key = StringToBinaryFormat(key);                key2 = StringToBinaryFormat(key2);                key3 = StringToBinaryFormat(key3);                StreamReader sr = new StreamReader("out1.txt");                while (!sr.EndOfStream)                {                    s += sr.ReadLine();                }                sr.Close();                for(int e = 0; e < 3; e++)
                {
                    if( e == 2)
                    {                       
                        CutBinaryStringIntoBlocks(s);

                        for (int j = 0; j < quantityOfRounds; j++)
                        {
                            for (int i = 0; i < Blocks.Length; i++)
                            {
                                Blocks[i] = DecodeDES_One_Round(Blocks[i], key);
                            }

                            key = KeyToPrevRound(key);
                        }

                        result = "";
                        for (int i = 0; i < Blocks.Length; i++)
                        {
                            result += Blocks[i];
                        }
                        s = result;
                        key = KeyToNextRound(key);

                        encodeKey = StringFromBinaryToNormalFormat(key);
                        Console.WriteLine("EncodeKey: " + encodeKey);
                        Console.WriteLine("result: " + StringFromBinaryToNormalFormat(result));
                    }
                    if (e == 1)
                    {
                        CutBinaryStringIntoBlocks(s);

                        for (int j = 0; j < quantityOfRounds; j++)
                        {
                            for (int i = 0; i < Blocks.Length; i++)
                            {
                                Blocks[i] = DecodeDES_One_Round(Blocks[i], key2);
                            }

                            key2 = KeyToPrevRound(key2);
                        }
                        
                        result = "";
                        for (int i = 0; i < Blocks.Length; i++)
                        {
                            result += Blocks[i];
                        }
                        s = result;

                        key2 = KeyToNextRound(key2);

                        encodeKey2 = StringFromBinaryToNormalFormat(key2);
                        Console.WriteLine("EncodeKey2: " + encodeKey2);
                        Console.WriteLine("result: " + StringFromBinaryToNormalFormat(result));
                    }
                    if (e == 0)
                    {
                        s = StringToBinaryFormat(s);
                        CutBinaryStringIntoBlocks(s);

                        for (int j = 0; j < quantityOfRounds; j++)
                        {
                            for (int i = 0; i < Blocks.Length; i++)
                            {
                                Blocks[i] = DecodeDES_One_Round(Blocks[i], key3);
                            }

                            key3 = KeyToPrevRound(key3);
                        }

                        result = "";
                        for (int i = 0; i < Blocks.Length; i++)
                        {
                            result += Blocks[i];
                        }
                        s = result;

                        key3 = KeyToNextRound(key3);

                        encodeKey3 = StringFromBinaryToNormalFormat(key3);
                        Console.WriteLine("EncodeKey3: " + encodeKey3);
                        Console.WriteLine("result: " + StringFromBinaryToNormalFormat(result));
                    }                   
                }                result = "";                for (int i = 0; i < Blocks.Length; i++)                {                    result += Blocks[i];                }                StreamWriter sw = new StreamWriter("out2.txt");                sw.WriteLine(StringFromBinaryToNormalFormat(result));                sw.Close();                Process.Start("out2.txt");            }            else            {                Console.WriteLine("Введите ключевое слово!");            }        }

        //доводим строку до размера, чтобы делилась на sizeOfBlock
        public static string StringToRightLength(string input)        {            while (((input.Length * sizeOfChar) % sizeOfBlock) != 0)            {                input += "#";            }            return input;        }

        //разбиение обычной строки на блоки
        public static void CutStringIntoBlocks(string input)        {            Blocks = new string[(input.Length * sizeOfChar) / sizeOfBlock];            int lengthOfBlock = input.Length / Blocks.Length;            for (int i = 0; i < Blocks.Length; i++)            {                Blocks[i] = input.Substring(i * lengthOfBlock, lengthOfBlock);                Blocks[i] = StringToBinaryFormat(Blocks[i]);            }        }

        //довести исходное сообщение до такого размера (в битах), чтобы оно нацело делилось на размер блока (sizeOfBlock = 128 бит);
        public static void CutBinaryStringIntoBlocks(string input)        {            Blocks = new string[input.Length / sizeOfBlock];            int lengthOfBlock = input.Length / Blocks.Length;            for (int i = 0; i < Blocks.Length; i++)            {                Blocks[i] = input.Substring(i * lengthOfBlock, lengthOfBlock);            }        }

        //перевод строки в двоичный формат
        public static string StringToBinaryFormat(string input)        {            string output = "";            for (int i = 0; i < input.Length; i++)            {                string char_binary = Convert.ToString(input[i], 2);                while (char_binary.Length < sizeOfChar)                {                    char_binary = "0" + char_binary;                }                output += char_binary;            }            return output;        }

        //доводим длину ключа до нужной
        public static string CorrectKeyWord(string input, int lengthKey)        {            if (input.Length > lengthKey)            {                input = input.Substring(0, lengthKey);            }            else            {                while (input.Length < lengthKey)                {                    input = "0" + input;                }            }            return input;        }

        //шифрование DES один раунд
        public static string EncodeDES_One_Round(string input, string key)        {            string L = input.Substring(0, input.Length / 2);            string R = input.Substring(input.Length / 2, input.Length / 2);            return (R + XOR(L, f(R, key)));        }

        //расшифровка DES один раунд
        public static string DecodeDES_One_Round(string input, string key)        {            string L = input.Substring(0, input.Length / 2);            string R = input.Substring(input.Length / 2, input.Length / 2);            return (XOR(f(L, key), R) + L);        }

        //XOR двух строк с двоичными данными
        public static string XOR(string s1, string s2)        {            string result = "";            for (int i = 0; i < s1.Length; i++)            {                bool a = Convert.ToBoolean(Convert.ToInt32(s1[i].ToString()));                bool b = Convert.ToBoolean(Convert.ToInt32(s2[i].ToString()));                if (a ^ b)                {                    result += "1";                }                else                {                    result += "0";                }            }            return result;        }

        //шифрующая функция f. в данном случае это XOR
        public static string f(string s1, string s2)        {            return XOR(s1, s2);        }

        //вычисление ключа для следующего раунда шифрования. циклический сдвиг >> 2
        public static string KeyToNextRound(string key)        {            for (int i = 0; i < shiftKey; i++)            {                key = key[key.Length - 1] + key;                key = key.Remove(key.Length - 1);            }            return key;        }

        //вычисление ключа для следующего раунда расшифровки. циклический сдвиг << 2
        public static string KeyToPrevRound(string key)        {            for (int i = 0; i < shiftKey; i++)            {                key = key + key[0];                key = key.Remove(0, 1);            }            return key;        }

        //переводим строку с двоичными данными в символьный формат
        public static string StringFromBinaryToNormalFormat(string input)        {            string output = "";            while (input.Length > 0)            {                string char_binary = input.Substring(0, sizeOfChar);                input = input.Remove(0, sizeOfChar);                int a = 0;                int degree = char_binary.Length - 1;                foreach (char c in char_binary)                {                    a += Convert.ToInt32(c.ToString()) * (int)Math.Pow(2, degree--);                }                output += ((char)a).ToString();            }            return output;        }
    }
}
