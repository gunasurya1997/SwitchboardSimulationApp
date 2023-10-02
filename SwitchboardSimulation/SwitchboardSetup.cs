using SwitchboardSimulation.Utilities;
using System;

namespace SwitchboardSimulation
{
    public class SwitchboardSetup
    {
        public static Switchboard SetupSwitchboard()
        {
            Console.Clear();
            Console.WriteLine("Switchboard Setup - Welcome!");
            Console.WriteLine("--------------------------------");

            int numFans = InputValidator.GetValidInput("Enter the number of fans: ");
            int numACs = InputValidator.GetValidInput("Enter the number of ACs: ");
            int numBulbs = InputValidator.GetValidInput("Enter the number of bulbs: ");

            Console.WriteLine("--------------------------------");

            // Create an instance of the Switchboard
            Switchboard switchboard = new Switchboard();

            AddAppliances(switchboard, Enums.ApplianceType.Fan, numFans);
            AddAppliances(switchboard, Enums.ApplianceType.AC, numACs);
            AddAppliances(switchboard, Enums.ApplianceType.Bulb, numBulbs);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Setup completed.");
            Console.WriteLine("--------------------------------");

            return switchboard;
        }

        private static void AddAppliances(Switchboard switchboard, Enums.ApplianceType type, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                Appliance appliance = new Appliance(type, i);
                Switch switchForAppliance = new Switch(appliance);
                switchboard.AddSwitch(switchForAppliance);
            }
        }
    }
}
