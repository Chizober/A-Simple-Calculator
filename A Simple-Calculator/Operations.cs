using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Simple_Calculator
{
    public class Operations
    {
        public static void SimpleOperations()
        {
            do
            {
                double result = 0;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\tA Simple Calculator App");
                Console.WriteLine("\t\t\t============================\n");
                Console.WriteLine(
                    "\t\t\t 1. Addition Operation\n"
                        + "\t\t\t 2. Subtraction Operation\n"
                        + "\t\t\t 3. Multiplication Operation\n"
                        + "\t\t\t 4. Division Operation\n"
                        + "\t\t\t 5. Modulus Operation"
                );

                Console.ResetColor();
                double num1;
                Console.WriteLine("\nEnter number 1:");
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("invalid input,please try again");
                }
                double num2;
                Console.WriteLine("\nEnter number 2:");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("invalid input,please try again");
                }
                Console.Write(
                    "Enter operator \n"
                        + "\t + : Add\n"
                        + "\t - : Subtract\n"
                        + "\t * : Multiply\n"
                        + "\t / : Divide\n"
                        + "\t % : Modulus\n"
                        + "\t B : BodMas\n"
                );

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"\nYour Result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"\n Your Result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"\nYour Result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"\nYour Result: {num1} / {num2} = " + result);
                        break;
                    case "%":
                        result = num1 % num2;
                        Console.WriteLine($"\nYour Result: {num1} % {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("Wrong input, please enter a valid number");
                        break;
                }
                Console.WriteLine("Would you like to Continue?(Y =yes,N =No):");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Bye!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
