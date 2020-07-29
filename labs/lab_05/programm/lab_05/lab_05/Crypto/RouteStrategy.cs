using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05.Crypto
{
    class RouteStrategy
    {
        public static string encrypt (string text)
        { 
            return getSpiralFilledString(text);
        }

        public static string decrypt(string ciphertext)
        {

            return getNormalTextFromSpiral(ciphertext);
        }

        private static string getTextFromTable(char[,] table, int cols, int rows)
        {
            StringBuilder builder = new StringBuilder();
           
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    builder.Append(table[i, j]);
                }
            }

            return builder.ToString();
        }

        private static string getNormalTextFromSpiral(string text)
        {
            int textLength = text.Length;
            int cols = getCountOfColumns(textLength) -1;
            int rows = getCountOfRows(textLength) - 1;

            char[,] table = new char[rows, cols];
            int s = 0;

            
            for (int x = 0; x < rows; x++)
            {
                table[x,0] = text[s];               
                s++;
            }
            for (int y = 1; y < cols; y++)
            {
                table[rows - 1, y] = text[s];              
                s++;
            }
            for (int x = rows - 2; x >= 0; x--)
            {
                table[x, cols - 1] = text[s];              
                s++;
            }
            for (int y = cols - 2; y > 0; y--)
            {
                table[0, y] = text[s];             
                s++;
            }

            //Периметр заполнен. Продолжаем заполнять массив и задаём
            //координаты ячейки, которую необходимо заполнить следующей.
            int c = 1;
            int d = 1;

            while (s < (cols * rows)-1)
            {
                //Периметр мы заполнили числами, отличными от нулей.
                //Следующие циклы поочерёдно работают, заполняя ячейки.
                //Вложенный цикл останавливается, если следующая ячейка имеет 
                //значение, отличное от ноля. Ячейка, на которой остановился 
                //цикл, не заполняется. Из-за этого условие для выхода из внешнего
                //цикла - (s>1). Если Вы поставите 0, получится вечный цикл. 

                //Движемся вниз.
                while (table[c + 1,d] == '\0')
                {
                    table[c,d] = text.ElementAt(s);
                    s++;
                    c++;
                }
                //Движемся вправо.
                while (table[c,d + 1] == '\0')
                {
                    table[c,d] = text.ElementAt(s);
                    s++;
                    d++;
                }

                //Движемся вверх.
                while (table[c - 1,d] == '\0')
                {
                    table[c,d] = text.ElementAt(s);
                    s++;
                    c--;
                }

                //Движемся влево.
                while (table[c,d - 1] == '\0')
                {
                    table[c,d] = text.ElementAt(s);
                    s++;
                    d--;
                }

            }

            //При данном решении в центре всегда остаётся незаполненная ячейка.
            //Убираем её при помощи следующего цикла.
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    if (table[x,y] =='\0')
                    {
                        table[x,y] = text.ElementAt(s);
                    }
                }
            }


            return getTextFromTable(table, cols, rows);
        }

        private static char[,] getTableFromText(string text, int countOfColumns, int countOfRows)
        {
            char[,] table = new char[countOfColumns, countOfRows];

            int counter = 0;
            for (int i = 0; i < countOfRows; i++)
            {
                for (int j = 0; j < countOfColumns; j++)
                {
                    if(counter >= text.Length)
                    {
                        table[i, j] = '_';
                    }
                    else
                    {
                        table[i, j] = text.ElementAt(counter);
                    }
                    
                    counter++;
                }
            }

            return table;
        }


        private static string getSpiralFilledString(string text)
        {
            int textLength = text.Length;
            int cols = getCountOfColumns(textLength);
            int rows = getCountOfRows(textLength);

            char[,] table = getTableFromText(text, cols, rows);

            StringBuilder builder = new StringBuilder();
            int counter = 1;


            for (int x = 0; x < rows; x++)
            {
                builder.Append(table[x,0]);
                table[x, 0] = '\0';
                counter++;
            }
            for (int y = 1; y < cols; y++)
            {
                builder.Append(table[rows-1,y]);
                table[rows-1,y] = '\0';
                counter++;
            }
            for (int x = rows - 2; x >= 0; x--)
            {
                builder.Append(table[x, cols-1]);
                table[x, cols - 1] = '\0';
                counter++;
            }
            for (int y = cols - 2; y >= 1; y--)
            {
                builder.Append(table[0,y]);
                table[0,y] = '\0';
                counter++;
            }

            //Периметр заполнен. Продолжаем заполнять массив и задаём
            //координаты ячейки, которую необходимо заполнить следующей.
            // c - row
            // d - col
            int c = 1;
            int d = 1;

            while (counter < (cols * rows))
            {
                //Периметр мы заполнили числами, отличными от нулей.
                //Следующие циклы поочерёдно работают, заполняя ячейки.
                //Вложенный цикл останавливается, если следующая ячейка имеет 
                //значение, отличное от ноля. Ячейка, на которой остановился 
                //цикл, не заполняется.

                //Движемся вниз.
                while (table[c + 1,d] != '\0')
                {
                    builder.Append(table[c,d]);
                    table[c, d] = '\0';
                    counter++;
                    c++;
                }
                
                //Движемся вправо.
                while (table[c, d + 1] != '\0')
                {
                    builder.Append(table[c,d]);
                    table[c, d] = '\0';
                    counter++;
                    d++;
                }

                //Движемся вверх.
                while (table[c - 1,d] != '\0')
                {
                    builder.Append(table[c,d]);
                    table[c, d] = '\0';
                    counter++;
                    c--;
                }

                //Движемся влево.
                while (table[c,d - 1] != '\0')
                {
                    builder.Append(table[c,d]);
                    table[c, d] = '\0';
                    counter++;
                    d--;
                }
            }

            //При данном решении в центре всегда остаётся незаполненная ячейка.
            //Убираем её при помощи следующего цикла.
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    if(table[x, y] != '\0')
                        builder.Append(table[x, y]);
                }
            }


            return builder.ToString();

        }
        
        private static int getCountOfColumns(int textLength)
        {
            return (int) Math.Floor(Math.Sqrt(textLength) + 1);
        }

        private static int getCountOfRows(int textLength)
        {
            return (int) Math.Floor(Math.Sqrt(textLength) + 1);
        }
    }
}
