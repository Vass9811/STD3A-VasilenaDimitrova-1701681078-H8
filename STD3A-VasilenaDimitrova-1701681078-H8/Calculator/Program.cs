using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Do you want to calculate some numbers? yes or no");
                answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("Enter first number:");
                    int FirstNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number:");
                    int SecondNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter operation:");
                    char operation = char.Parse(Console.ReadLine());

                    switch (operation)
                    {
                        case '+':
                            double result = (FirstNum + SecondNum) + 0.1;
                            double roudedresult = Math.Round(result, 2);
                            Console.WriteLine("The result is {0}", roudedresult);
                            break;

                        case '-':
                            if (FirstNum > SecondNum)
                            {
                                double minusresult = (FirstNum * FirstNum) - SecondNum;
                                double roundedminusresult = Math.Round(minusresult, 2);
                                Console.WriteLine("The result is {0}", roundedminusresult);
                            }
                            else
                            {
                                double minusresult = (SecondNum * SecondNum) - FirstNum;
                                double roundedminusresult = Math.Round(minusresult, 2);
                                Console.WriteLine("The result is {0}", roundedminusresult);
                            }
                            break;


                        case '*':
                            double multiplication = FirstNum * Math.Sqrt(SecondNum);
                            double roudedmultiplication = Math.Round(multiplication);
                            Console.WriteLine("The result is {0}", roudedmultiplication);

                            break;

                        case '/':
                            if (SecondNum == 0)
                            {
                                Console.WriteLine("Error!You can't divide to 0");
                            }
                            else
                            {
                                double dividedresult = FirstNum / SecondNum;
                                double roudeddividedresult = Math.Round(dividedresult, 2);
                                Console.WriteLine("The result is {0}", roudeddividedresult);
                            }
                            break;
                    }
                }
                if (answer == "no")
                {
                    break;
                }
            }
            while (true);
        }
    }
}
