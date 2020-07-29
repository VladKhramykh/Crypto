using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05.Crypto
{
    class MultipleReshuffleStrategy
    {
        //BEL ALPHABET
        static public char[] characters = new char[] {
            'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
            'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
            'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ',
            'Ы', 'Ь', 'Ъ', 'Э', 'Ю', 'Я'
        };

        static int rowsNum = 0;
        static int colsNum = 0;
        static public char[,] table; 

        static public string Encrypt(string input, string keySurname, string keyName)
        {

            rowsNum = keySurname.Length;
            colsNum = keyName.Length;

            // ВЛАД - 2413
            // ХРАМЫХ - 431265
            string keyNamePositions = "2413";
            string keySurnamePositions = "431265";

            ClearTable();
            WriteTable_R(input);

            char[,] temp = (char[,])table.Clone();
            int counter = 0;

            foreach (char c in keySurnamePositions)
            {
                int pos = int.Parse(c.ToString()) - 1;

                for (int i = 0; i < colsNum; i++)
                {
                    table[pos, i] = temp[counter, i];
                }
                counter++;
            }

            counter = 0;
            temp = (char[,])table.Clone();
            foreach (char c in keyNamePositions)
            {
                int pos = int.Parse(c.ToString()) - 1;

                for (int i = 0; i < rowsNum; i++)
                {
                    table[i, pos] = temp[i, counter];
                }
                counter++;

            } 
 
            return ReadTable_C();
           

        }

        static public string Decrypt(string input, string keySurname, string keyName)
        {
            rowsNum = keySurname.Length;
            colsNum = keyName.Length;

            // ВЛАД - 2413
            // ХРАМЫХ - 431265
            string keyNamePositions = "2413";
            string keySurnamePositions = "431265";

            ClearTable();
            WriteTable_C(input);
            char[,] temp = (char[,])table.Clone();
            int counter = 0;

            foreach (char c in keyNamePositions)
            {
                int pos = int.Parse(c.ToString()) - 1;

                for (int i = 0; i < rowsNum; i++)
                {
                    table[i, counter] = temp[i, pos];
                }
                counter++;
            }

            counter = 0;
            temp = (char[,])table.Clone();
            foreach (char c in keySurnamePositions)
            {
                int pos = int.Parse(c.ToString()) - 1;

                for (int i = 0; i < colsNum; i++)
                {
                    table[counter, i] = temp[pos, i];
                }
                counter++;
            }
            return ReadTable_R();
        }

        static public void WriteTable_R(string input)
        {
            int counter = 0;
            for (int i = 0; i < rowsNum; i++)
            {
                for (int j = 0; j < colsNum; j++)
                {
                    if (counter < input.Length)
                    {
                        table[i, j] = input.ElementAt(counter);
                        counter++;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        static public void WriteTable_C(string input)
        {
            int counter = 0;
            for (int i = 0; i < colsNum; i++)
            {
                for (int j = 0; j < rowsNum; j++)
                {
                    if (counter < input.Length)
                    {
                        table[j, i] = input.ElementAt(counter);
                        counter++;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        static public string ReadTable_C()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < colsNum; i++)
            {
                for (int j = 0; j < rowsNum; j++)
                {
                    result.Append(table[j, i]);
                }
            }
            return result.ToString();
        }

        static public string ReadTable_R()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < rowsNum; i++)
            {
                for (int j = 0; j < colsNum; j++)
                {
                    result.Append(table[i, j]);
                }
            }
            return result.ToString();
        }

        
        static public void ClearTable()
        {
            table = new char[rowsNum, colsNum];
        }


        private static int getCountOfColumns(int textLength)
        {
            return (int)Math.Floor(Math.Sqrt(textLength) + 1);
        }

        private static int getCountOfRows(int textLength)
        {
            return (int)Math.Floor(Math.Sqrt(textLength) + 1);
        }
    }
}
