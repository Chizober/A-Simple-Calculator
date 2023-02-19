using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Simple_Calculator
{
    public static class Menu
    {
        public static void ShowMenu()
        {
            string input;
            begin:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(
                "\t\t\tWHAT WOULD YOU LIKE TO DO?\n\n"
                    + "\t\t 1. Make a simple Calculation using operators \n"
                    + "\t\t 2. Using Math Functions\n"
                    + "\t\t 3. Press 3 to Exit \n"
            );
            Console.ResetColor();
            Console.Write("Pick One Option:");
            input = Console.ReadLine();
            if (input == "1")
                goto SimpleOperations;
            if (input == "2")
                goto MathFunctions;
            if (input == "3")
                System.Environment.Exit(1);
            Console.WriteLine("Invalid option!");
            goto begin;
            SimpleOperations:
            {
                Operations.SimpleOperations();
                goto begin;
            }
            MathFunctions:
            {
                MathFunctions.ShowMathsFunctions();
                goto begin;
            }
        }
    }
}
