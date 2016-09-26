using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_1_.Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var ammountPhoto = int.Parse(Console.ReadLine());
            var ammountTimeRequire = int.Parse(Console.ReadLine());
            var PrecentGoods = int.Parse(Console.ReadLine()); ;
            long ammountTimeUp = long.Parse(Console.ReadLine());

            var totalGoodPhoto = (int)Math.Ceiling((ammountPhoto * PrecentGoods) / 100.0);



            long ammountofALL = ammountTimeRequire * ammountPhoto; // in SECS
            long ammountofGod = totalGoodPhoto * ammountTimeUp; //in SECS

            long totalTime = ammountofALL + ammountofGod; // in secs

            long days = totalTime / 86400;
            long daysLeft = totalTime % 86400;
            long hours = daysLeft / 3600;
            long hoursLeft = daysLeft % 3600;
            long min = hoursLeft / 60;
            long sec = hoursLeft % 60;


            Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}", days, hours, min, sec);
        }
    }
}
