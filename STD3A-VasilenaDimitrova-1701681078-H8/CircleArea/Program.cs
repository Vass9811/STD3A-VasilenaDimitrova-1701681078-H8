using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int r = rnd.Next(33, 187);
            Console.WriteLine("The radius of the circle is {0}",r);
            double s = Math.PI * (r * r);
            double roudeds = Math.Round(s, 2);
            Console.WriteLine("The circle area is: {0}",roudeds);
          

        }
    }
}
