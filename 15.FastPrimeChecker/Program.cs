﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num; i++)
            {
                bool isPrime = true;
                for (int i2 = 2; i2 <= Math.Sqrt(i); i2++)
                {
                    if (i % i2 == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }

        }
    }
}
