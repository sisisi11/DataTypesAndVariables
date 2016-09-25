using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long PersonalId = long.Parse(Console.ReadLine());
            uint employeeNumber = uint.Parse(Console.ReadLine());
            ulong minNumb = 27560000;
            ulong maxNumb = 27569999;

            while (minNumb <= maxNumb)
            {
                Console.WriteLine(firstName);
                Console.WriteLine(lastName);
                Console.WriteLine(age);
                Console.WriteLine(gender);
                Console.WriteLine(PersonalId);
                Console.WriteLine(employeeNumber);

                minNumb++;
            }          
        }
    }
}
