using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(1, 999);
            double rootNum = Math.Sqrt(randomNum);
            Console.WriteLine("The random number of the day is {0}",randomNum);
            if(rootNum >= 1 && rootNum <300)
            {
                double day = rootNum * 5.1;
                double month = day * 30;
                Console.WriteLine("The money savings for a day: {0}",day);
                Console.WriteLine("The money savings for a month: {0}",month);
            }
            if(rootNum>=301 && rootNum<600)
            {
                double day = rootNum * 10.098;
                double roundedday = Math.Round(day, 4);
                double month = day * 30;
                double roundedmonth = Math.Round(month, 4);
                Console.WriteLine("The money savings for a day: {0}",roundedday);
                Console.WriteLine("The money savings for a month: {0}",roundedmonth);
            }
            if(rootNum>=601 && rootNum<999)
            {
                double day = rootNum * 100.00001;
                double roundedday = Math.Round(day, 4);
                double month = day * 30;
                double roundedmonth = Math.Round(month, 4);
                Console.WriteLine("The money savings for a day: {0}", roundedday);
                Console.WriteLine("The money savings for a month: {0}", roundedmonth);
            }
        }
    }
}
