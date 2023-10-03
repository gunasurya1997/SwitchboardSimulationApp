using System;

namespace SwitchboardSimulation.Utilities
{
    public class InputValidator
    {
        public static int GetValidInput(string prompt)
        {
            int input = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write(prompt);
                string inputString = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputString))
                {
                    Console.WriteLine("Input cannot be empty. Please enter a non-negative integer.");
                }
                else
                {
                    isValidInput = int.TryParse(inputString, out input);

                    if (!isValidInput || input < 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                        isValidInput = false;
                    }
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
                string choiceString = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(choiceString))
                {
                    Console.WriteLine("Choice cannot be empty. Please enter a number.");
                }
                else
                {
                    isValidChoice = int.TryParse(choiceString, out choice);

                    if (!isValidChoice || choice < minValue || choice > maxValue)
                    {
                        Console.WriteLine($"Invalid choice. Please enter a number between {minValue} and {maxValue}.");
                        isValidChoice = false;
                    }
                }
            }

            return choice;
        }
    }
}
