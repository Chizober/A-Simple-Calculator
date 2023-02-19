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
                "\n\t\t\t\t\tWHAT WOULD YOU LIKE TO DO?\n\n"
                    + "\t\t\t\t\t 1. MAKE A SIMPLE CALCULATION USING OPERATORS \n"
                    + "\t\t\t\t\t 2. USING MATH FUNCTIONS\n"
                    + "\t\t\t\t\t 3. PRESS 3 TO EXIT \n"
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
