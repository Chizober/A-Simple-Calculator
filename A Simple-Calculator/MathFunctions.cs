using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Simple_Calculator
{
    public static class MathFunctions
    {
        public static void ShowMathsFunctions()
        {
            string input;
            double num3;
            double num4;
            double num5;
            double num6;
            double num7;
            Console.WriteLine(
                "\n\n\t...................Pick one Thread Option...................\n\n"
                    + "\t\tType A to Check for square root\n"
                    + "\t\tType B to round a number.\n"
                    + "\t\tType C to check for power a number.\n"
                    + "\t\tType D to check for absolute value a number.\n"
            );
            input = "";

            while (input != "A" && input != "B" && input != "C" && input != "D")
            {
                Console.WriteLine("\nPlease select A or B or C or D");
                input = Console.ReadLine();
                input = input.ToUpper();
            }
            if (input == "A")
                goto A;
            if (input == "B")
                goto B;
            if (input == "C")
                goto C;
            if (input == "D")
                goto D;
            A:
            {
                num3 = 0;
                Console.WriteLine("Enter number to find square root:\n");
                while (!double.TryParse(Console.ReadLine(), out num3))
                {
                    Console.WriteLine("invalid input,please try again");
                }
                Console.WriteLine(Math.Sqrt(num3));
                Menu.ShowMenu();
            }
            B:
            {
                num4 = 0;
                Console.WriteLine("Enter number to round:\n");
                while (!double.TryParse(Console.ReadLine(), out num4))
                {
                    Console.WriteLine("invalid input,please try again");
                }
                Console.WriteLine(Math.Round(num4));
                Menu.ShowMenu();
            }
            C:
            {
                num5 = 0;
                Console.WriteLine("Enter number 1 to get Power,Min and Max:");
                while (!double.TryParse(Console.ReadLine(), out num5))
                {
                    Console.WriteLine("invalid input,please try again");
                }
                num6 = 0;
                Console.WriteLine("Enter number 2 to get power,Min and Max:");
                while (!double.TryParse(Console.ReadLine(), out num6))
                {
                    Console.WriteLine("invalid input,please try again");
                }
                Console.WriteLine($"The power of {num5} and {num6} is {Math.Pow(num5, num6)}");
                Console.WriteLine(
                    $"The highest value of {num5} and {num6} is {Math.Max(num5, num6)}"
                );
                Console.WriteLine(
                    $"The lowest value of {num5} and {num6} is {Math.Min(num5, num6)}\n"
                );

                Menu.ShowMenu();
            }

            D:
            {
                num7 = 0;
                Console.WriteLine("Enter number to round:\n");
                while (!double.TryParse(Console.ReadLine(), out num7))
                {
                    Console.WriteLine("invalid input,please try again");
                }
                Console.WriteLine(Math.Abs(num7));
                Menu.ShowMenu();
            }
        }
    }
}
