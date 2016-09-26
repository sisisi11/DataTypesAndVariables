using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 bananas, 4 eggs and 0.2 kilos berries == set of 6 ; 1 dessert = set of 6 ; 10 peoples = set of 12 (2 dessert) ; 5 pepole = set of 6 (1 dessert).

            float Cash = float.Parse(Console.ReadLine());
            int Peoples = int.Parse(Console.ReadLine());
            float banana = float.Parse(Console.ReadLine());
            float egg = float.Parse(Console.ReadLine());
            float berry = float.Parse(Console.ReadLine());

            int DessertCount = 0;

            do
            {
                DessertCount=0;
            }
            while (Peoples % 6 == 0);
            {
                DessertCount++;
                
            }
            Console.WriteLine(Cash);
        }
    }
}
