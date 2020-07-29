using System;
namespace lab_08
{
    public class RSA
    {
        private long P, Q, E, X0, N;

        public RSA(long p, long q, long e, long seed)
        {
            P = p;
            Q = q;
            X0 = seed;
            E = e;
            N = P * Q;

            if(nodForTwo(e, (P-1)*(Q-1)) != 1)
            {
                throw new Exception("This numbers are not mutually simple");
            }
        }
        //Get next random number
        public long getRandNum()
        {
            long nextRandNum = Convert.ToInt64(Math.Pow(X0, E)) % N;
            X0 = nextRandNum;
            return nextRandNum;
        }
        // Get next random bit
        public long getRandBit()
        {
            return Convert.ToInt32(getRandNum() & 1);
        }

        private long nodForTwo(long a, long b)
        {
            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
    }
}
