using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelorDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            long digit = long.MinValue;
            long digit1 = long.MaxValue;
            decimal digit2 = decimal.MinValue;
            decimal digit3 = decimal.MinValue;


            if (symbol == 'a' || symbol == 'o' || symbol == 'e' || symbol == 'u' || symbol == 'i')
            {
                Console.WriteLine("vowel ");
            }
            else if(symbol == '0' || symbol == '1' || symbol == '2' || symbol == '3' || symbol == '4' || symbol == '5' || symbol == '6' || symbol == '7' || symbol == '8' || symbol == '9')
            {
                Console.WriteLine("digit");
            }     
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
