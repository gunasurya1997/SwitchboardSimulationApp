using static SwitchboardSimulation.Utilities.Enums;

namespace SwitchboardSimulation.Models
{
    public class Appliance
    {
        public ApplianceType Type { get; }
        public int Id { get; }
        public Appliance(ApplianceType type, int number)
        {
            Type = type;
            Id = number;
        }

        // Method to get the name of the appliance based on its type
        public string GetName()
        {
            return $"{Type} {Id}";
        }
    }
}
