
using static SwitchboardSimulation.Utilities.Enums;

namespace SwitchboardSimulation.Models
{
    public class Appliance
    {
        public ApplianceType Type { get; }
        public Switch AssociatedSwitch { get; }
        public bool IsOn { get; private set; }
        public int Number { get; }
        public Appliance(ApplianceType type, int number)
        {
            Type = type;
            AssociatedSwitch = new Switch(this);
            IsOn = false;
            Number = number;
        }

        // Method to get the name of the appliance based on its type
        public string GetName()
        {
            return $"{Type} {Number}";
        }
    }
}