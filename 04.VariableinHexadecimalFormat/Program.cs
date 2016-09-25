using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _04.VariableinHexadecimalFormat
{
    class Program
    {
        static void Main()
        {

            {
                
                string hexValue = Console.ReadLine();
                
                int intValue = Convert.ToInt32(hexValue, 16);
                Console.WriteLine(intValue);
            }
        }

    }
}

