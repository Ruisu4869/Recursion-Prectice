using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion_Prectice
{
    class Exercises
    {
        public int s;
        public int n;
        public int PNumber;
        public int t;
        public int SumNum(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else
            {
                s = num + SumNum(num - 1);
                return s;
            }
        }
        public int SumDig(int num)
        {
            if (num % 10 == 0)
            {
                return num;
            }
            else
            {
                int s = num % 10;
                n = num / 10;
                n = s + SumDig(n);
                return n;
            }
        }

        public int PrimeNum(int num)
        {
            PNumber = num / 2;
            if (PNumber == 1)
            {
                return 1;
            }
            else
            {
                int j = num % PNumber;
                if (j == 0)
                {
                    return 0;
                }
                else
                {
                    PNumber = PNumber - 1;
                    PrimeNum(num);
                    return num;
                }
            }
            int NotPrime = PrimeNum(num);
            if (NotPrime == 10)
            {
                Console.WriteLine(num + " is a prime number");
                return num;
            }
            else
            {
                Console.WriteLine(num + " isn't a prime number");
                return num;
            }
        }
        public int JumpSpiderman(int num)
        {
            int h = num;
            if (num > 0)
            {
                return num;
            }
            else
            {
                t = JumpSpiderman(num - 2) + JumpSpiderman(num - 1);
            }
            return t;
        }

        public int JumpsQuantity(int jump)
        {
            int d;
            d = JumpSpiderman(jump + 1);
            return d;
        }

    }
}
