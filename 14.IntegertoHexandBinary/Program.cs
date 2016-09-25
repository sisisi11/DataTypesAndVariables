using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegertoHexandBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int intValue = int.Parse(Console.ReadLine());
            string hexValue = Convert.ToString(intValue, 16).ToUpper();
            string upperString = Convert.ToString(intValue, 2).ToString();
            Console.WriteLine(hexValue);
            Console.WriteLine(upperString);

        }
    }
}
