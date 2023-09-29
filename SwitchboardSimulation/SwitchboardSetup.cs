using SwitchboardSimulation.Utilities;
using System;

namespace SwitchboardSimulation
{
    public class SwitchboardSetup
    {
        public static Switchboard SetupSwitchboard()
        {
            Console.WriteLine("Switchboard Simulator - Welcome!");

            int numFans = InputValidator.GetValidInput("Enter the number of fans: ");
            int numACs = InputValidator.GetValidInput("Enter the number of ACs: ");
            int numBulbs = InputValidator.GetValidInput("Enter the number of bulbs: ");

            // Create an instance of the Switchboard
            Switchboard switchboard = new Switchboard();

            for (int i = 1; i <= numFans; i++)
            {
                Appliance appliance = new Appliance(Enums.ApplianceType.Fan, i);
                Switch switchForFan = new Switch(appliance);
                switchboard.AddSwitch(switchForFan);
            }

            for (int i = 1; i <= numACs; i++)
            {
                Appliance appliance = new Appliance(Enums.ApplianceType.AC, i);
                Switch switchForAC = new Switch(appliance);
                switchboard.AddSwitch(switchForAC);
            }

            for (int i = 1; i <= numBulbs; i++)
            {
                Appliance appliance = new Appliance(Enums.ApplianceType.Bulb, i);
                Switch switchForBulb = new Switch(appliance);
                switchboard.AddSwitch(switchForBulb);
            }

            return switchboard;
        }
    }
}
