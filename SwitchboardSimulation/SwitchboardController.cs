using SwitchboardSimulation.Utilities;
using System;

namespace SwitchboardSimulation
{
    public class SwitchboardController
    {
        public static void DisplayMenu(Switchboard switchboard)
        {
            Console.Clear();
            Console.WriteLine("Switchboard Menu:");
            Console.WriteLine("---------------------------------------------");

            for (int i = 0; i < switchboard.Switches.Count; i++)
            {
                string applianceName = switchboard.Switches[i].AssociatedAppliance.GetName();
                string applianceStatus = switchboard.Switches[i].IsOn ? "On" : "Off";
                Console.WriteLine($"{i + 1}. {applianceName} is {applianceStatus}");
            }

            Console.WriteLine("0. Exit");
            Console.WriteLine("---------------------------------------------");
        }

        public static void ControlAppliances(Switchboard switchboard)
        {
            while (true)
            {
                DisplayMenu(switchboard);

                Console.Write("Enter your choice (0-3): ");
                int choice = InputValidator.GetValidChoice(0, switchboard.Switches.Count);

                if (choice == 0)
                {
                    break;
                }
                else if (choice >= 1 && choice <= switchboard.Switches.Count)
                {
                    Switch selectedSwitch = switchboard.Switches[choice - 1];
                    Appliance selectedAppliance = selectedSwitch.AssociatedAppliance;
                    Console.WriteLine($"Selected {selectedAppliance.GetName()}:");
                    Console.WriteLine("---------------------------------------------");

                    string toggleOption = selectedSwitch.IsOn ? "Off" : "On";
                    Console.WriteLine($"1. Switch {selectedAppliance.GetName()} {toggleOption}");
                    Console.WriteLine("2. Back");

                    Console.Write("Enter your choice (1-2): ");
                    int applianceChoice = InputValidator.GetValidChoice(1, 2);

                    if (applianceChoice == 1)
                    {
                        selectedSwitch.Toggle();
                    }
                }
            }
        }

        public static void Start(Switchboard switchboard)
        {
            ControlAppliances(switchboard);
        }
    }
}
