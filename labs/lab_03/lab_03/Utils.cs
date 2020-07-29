using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03
{
    public class Utils
    {
        // dlya nahojdeniya chisla obr po modulu

       private int GCD1(int a, int b, out int x, out int y)
        {
            if (nodForTwo(a, b) != 1)
            {
                throw new ArithmeticException();
            }
            else
            {
                if (a == 0)
                {
                    x = 0;
                    y = 1;
                    return b;
                }
                int x1, y1;
                int d = GCD1(b % a, a, out x1, out y1);
                x = y1 - (b / a) * x1;
                y = x1;
                return d;
            }
            
        }

        public int ReverseMod(int a, int m)
        {
            int x, y;
            int g = GCD1(a, m, out x, out y);
            if (g != 1)
                throw new ArgumentException();
            return (x % m + m) % m;
        }

        // for find NOD

        public int nodForTwo(int a, int b)
        {
            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public int nodForThree(int a, int b, int c)
        {
            return nodForTwo(nodForTwo(a, b), c);
        }

        public int nodForFour(int a, int b, int c, int d)
        {
            return nodForTwo(nodForTwo(a, b), nodForTwo(c, d));
        }
        
        // for find simple numbers

        private bool isSimple(int number)
        {
            for (int i = 2; i <= (int)(number / 2); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public List<int> getSimpleByRange(int from, int to)
        {
            List<int> simlpeNumbers = new List<int>();
            
            for (int i = from; i <= to; i++)
            {
                if (isSimple(i))
                {
                    simlpeNumbers.Add(i);
                }
            }
            

            return simlpeNumbers;

        }
    }

   

}





