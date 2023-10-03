using SwitchboardSimulation.Models;
using SwitchboardSimulation.Utilities;

namespace SwitchboardSimulation.Services
{
    public class SwitchboardServices
    {
        public static Switchboard SetupSwitchboard(int numFans, int numACs, int numBulbs)
        {
            // Create an instance of the Switchboard
            Switchboard switchboard = new Switchboard();
            AddAppliances(switchboard, Enums.ApplianceType.Fan, numFans);
            AddAppliances(switchboard, Enums.ApplianceType.AC, numACs);
            AddAppliances(switchboard, Enums.ApplianceType.Bulb, numBulbs);
            return switchboard;
        }

        public static (Switch, Appliance) ControlAppliances(Switchboard switchboard, int choice)
        {
            Switch selectedSwitch = null;
            Appliance selectedAppliance = null;

            if (choice >= 1 && choice <= switchboard.Switches.Count)
            {
                selectedSwitch = switchboard.Switches[choice - 1];
                selectedAppliance = selectedSwitch.AssociatedAppliance;
            }
            return (selectedSwitch, selectedAppliance);
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

        public static void ToggleSwitch(int choice, Switch @switch)
        {
            if(choice == 1)
            {
                @switch.Toggle();
            }
        }
    }
}
