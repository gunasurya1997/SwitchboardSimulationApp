using System;

namespace SwitchboardSimulation.Utilities
{
    public static class InputValidator
    {
        public static int GetValidInput(string prompt)
        {
            int input = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write(prompt);
                isValidInput = int.TryParse(Console.ReadLine(), out input);

                if (!isValidInput || input < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                    isValidInput = false; 
                }
            }

            return input;
        }

        public static int GetValidChoice(int minValue, int maxValue)
        {
            int choice = 0;
            bool isValidChoice = false;

            while (!isValidChoice)
            {
                Console.Write($"Enter your choice ({minValue}-{maxValue}): ");
                isValidChoice = int.TryParse(Console.ReadLine(), out choice);

                if (!isValidChoice || choice < minValue || choice > maxValue)
                {
                    Console.WriteLine($"Invalid choice. Please enter a number between {minValue} and {maxValue}.");
                    isValidChoice = false; 
                }
            }

            return choice;
        }
    }
}
