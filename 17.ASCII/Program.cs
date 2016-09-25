using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());

            for (int i = (int)num1; i <= num2; i++)
            {
                char ascii = (char)(i);
                Console.Write(" " + ascii);
            }

        }
    }
}
