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

            for (int i = 0; i < switchboard.Switches.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {switchboard.Switches[i].AssociatedAppliance.GetName()} is {(switchboard.Switches[i].IsOn ? "On" : "Off")}");
            }

            Console.WriteLine("0. Exit");
        }

        public static void ControlAppliances(Switchboard switchboard)
        {
            while (true)
            {
                DisplayMenu(switchboard);

                int choice = InputValidator.GetValidChoice(0,switchboard.Switches.Count);

                if (choice == 0)
                {
                    break;
                }
                else
                {
                    Switch selectedSwitch = switchboard.Switches[choice - 1];
                    Appliance selectedAppliance = selectedSwitch.AssociatedAppliance;
                    Console.WriteLine($"Selected {selectedAppliance.GetName()}:");

                    string toggleOption = selectedSwitch.IsOn ? "Off" : "On";
                    Console.WriteLine($"1. Switch {selectedAppliance.GetName()} {toggleOption}");
                    Console.WriteLine("2. Back");

                    int applianceChoice = InputValidator.GetValidChoice(1,2);

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
