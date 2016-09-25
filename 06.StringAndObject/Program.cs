using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "World";

            object word3;
            word3 = word1 + " " + word2;

            Console.WriteLine(word3.ToString());
        }
    }
}
