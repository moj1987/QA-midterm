using System;

namespace QA_Midterm
{
    internal class Program
    {
        private static int integerCommand;
        private static int integerDimension;

        private const int MIN_MENU_ITEMS = 1;
        private const int MAX_MENU_ITEMS = 2;

        private static void Main(string[] args)
        {
            while (true)
            {
                GetCommand();
                ExecuteMenuCommand();
            }
        }

        private static void GetCommand()
        {
            bool IsCommandInteger = false;
            while (!IsCommandInteger)
            {
                ShowMenu();
                var inputString = ReadUserInput();
                IsCommandInteger = int.TryParse(inputString, out integerCommand);
            }

            if (integerCommand > MAX_MENU_ITEMS || integerCommand < MIN_MENU_ITEMS)
            {
                GetCommand();
            }
        }

        private static void ExecuteMenuCommand()
        {
            switch (integerCommand)
            {
                case 1:
                    var dimensionA = GetDimension();
                    var dimensionB = GetDimension();
                    var dimensionC = GetDimension();

                    var output = TriangleSolver.Analyze(dimensionA, dimensionB, dimensionC);
                    Console.WriteLine(output);
                    Console.WriteLine("********************");

                    break;

                case 2:
                    Environment.Exit(0);
                    break;
            }
        }

        private static int GetDimension()
        {
            bool hasRecivedValidNumber = false;
            while (!hasRecivedValidNumber)
            {
                Console.WriteLine("Enter a trianlge dimension");
                var inputString = ReadUserInput();
                hasRecivedValidNumber = int.TryParse(inputString, out integerDimension);
            }
            return integerDimension;
        }

        private static string ReadUserInput()
        {
            return Console.ReadLine();
        }

        private static void ShowMenu()
        {
            Console.WriteLine("1. Enter trianlge dimensions");
            Console.WriteLine("2. Exit");
        }
    }
}