using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BOOL
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = Console.ReadLine();
            bool boolValue = Convert.ToBoolean(string1);

            if (string1 == "true" || string1 == "True")
            {
                boolValue = true;
                Console.WriteLine("Yes");
            }
            else
            {
                boolValue = false;
                Console.WriteLine("No");
            }
            
        }
    }
}
