using SwitchboardSimulation.Models;
using SwitchboardSimulation.Services;
using SwitchboardSimulation.Utilities;
using System;
using static SwitchboardSimulation.Utilities.Enums;

namespace SwitchboardSimulation.App
{
    public class SwitchboardApplication
    {
        public static void Initialize()
        {
            Console.Clear();
            Console.WriteLine("Switchboard Setup - Welcome!");
            Console.WriteLine("--------------------------------");

            int numFans = InputValidator.GetValidInput("Enter the number of fans: ");
            int numACs = InputValidator.GetValidInput("Enter the number of ACs: ");
            int numBulbs = InputValidator.GetValidInput("Enter the number of bulbs: ");
            Console.WriteLine("--------------------------------");

            Switchboard switchboard = SwitchboardServices.SetupSwitchboard(numFans, numACs, numBulbs);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Setup completed.");
            Console.WriteLine("--------------------------------");
            while (true)
            {
                DisplayMenu(switchboard);
                int choice = InputValidator.GetValidChoice(0, switchboard.Switches.Count);
                if (choice == 0)
                {
                    Console.WriteLine("Exiting the Switchboard Simulation...");
                    break;
                }
                (Switch selectedSwitch, Appliance selectedAppliance) = SwitchboardServices.ControlAppliances(switchboard, choice);
                ShowSwitchMenu(selectedAppliance, selectedSwitch);
                int applianceChoice = InputValidator.GetValidChoice(1, 2);
                SwitchboardServices.ToggleSwitch(applianceChoice, selectedSwitch);
            }
        }
        private static void DisplayMenu(Switchboard switchboard)
        {
            Console.Clear();
            Console.WriteLine("═════════════════════════════════════════");
            Console.WriteLine("********** Switchboard Menu *************");
            Console.WriteLine("═════════════════════════════════════════");
            Console.WriteLine("No.\tAppliance\tSwitch State");
            Console.WriteLine("═════════════════════════════════════════");

            for (int i = 0; i < switchboard.Switches.Count; i++)
            {
                string applianceName = switchboard.Switches[i].AssociatedAppliance.GetName();
                State applianceStatus = switchboard.Switches[i].IsOn ? State.On : State.Off;

                Console.WriteLine($"{i + 1,-4}" +
                                  $"{applianceName,-20}" +
                                  $"{applianceStatus,-10}");
            }

            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine();
            Console.WriteLine("Enter \"0\" to Exit from the Menu");
            Console.WriteLine();
        }


        private static void ShowSwitchMenu(Appliance selectedAppliance, Switch selectedSwitch)
        {
            Console.WriteLine($"Selected {selectedAppliance.GetName()}:");
            Console.WriteLine("---------------------------------------------");

            State toggleOption = selectedSwitch.IsOn ? State.Off : State.On;
            Console.WriteLine($"1. Switch {selectedAppliance.GetName()} {toggleOption}");
            Console.WriteLine("2. Back");
        }
    }
}
