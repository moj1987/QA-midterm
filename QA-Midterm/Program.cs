using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Midterm
{
    internal class Program
    {
        public static string Input;
        public static string output;
        private static int integerCommand;
        private static int integerDimension;
        private static int dimensionA;
        private static int dimensionB;
        private static int dimensionC;
        private static int inputDimesions = 0;

        private static void Main(string[] args)
        {
            while (true)
            {
                InitiateMenuSelection();
                ExecuteMenuCommand();
                ResetAllNumbers();
            }
        }

        private static void InitiateMenuSelection()
        {
            ShowMenu();
            ReadUserInput();
            ValidateMenuSelection();
        }

        private static void ExecuteMenuCommand()
        {
            switch (integerCommand)
            {
                case 1:
                    GetDimensions();
                    output = TriangleSolver.Analyze(dimensionA, dimensionB, dimensionC);
                    Console.WriteLine(output);
                    Console.WriteLine("*** *** ***");
                    break;

                case 2:
                    Environment.Exit(0);
                    break;
            }
        }

        private static void ValidateMenuSelection()
        {
            IsInputInteger();
            CheckInputRage();
        }

        private static void CheckInputRage()
        {
            if (integerCommand > 2 || integerCommand < 1)
            {
                InitiateMenuSelection();
            }
        }

        private static void IsInputInteger()
        {
            if (!int.TryParse(Input, out integerCommand))
            {
                InitiateMenuSelection();
            }
        }

        private static void GetDimensions()
        {
            Console.WriteLine("Enter a trianlge dimension");
            ReadUserInput();
            IsDimensionInteger();
            inputDimesions++;

            switch (inputDimesions)
            {
                case 1:
                    dimensionA = integerDimension;
                    GetDimensions();
                    break;

                case 2:
                    dimensionB = integerDimension;
                    GetDimensions();
                    break;

                case 3:
                    dimensionC = integerDimension;
                    break;
            }

            while (inputDimesions < 3)
            {
                GetDimensions();
            }
        }

        private static void IsDimensionInteger()
        {
            if (!int.TryParse(Input, out integerDimension))
            {
                Console.WriteLine("Integer mate!!!!");
                GetDimensions();
            }
        }

        private static void ReadUserInput()
        {
            Input = Console.ReadLine();
        }

        private static void ShowMenu()
        {
            Console.WriteLine("1. Enter trianlge dimensions");
            Console.WriteLine("2. Exit");
        }

        private static void ResetAllNumbers()
        {
            inputDimesions = 0;
            dimensionA = 0;
            dimensionB = 0;
            dimensionC = 0;
        }
    }
}