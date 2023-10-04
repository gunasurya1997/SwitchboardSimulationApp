using System.ComponentModel;
using System.Reflection;
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

        public string GetName()
        {
            string applianceDescription = GetApplianceDescription();
            return $"{applianceDescription} {Id}";
        }

        private string GetApplianceDescription()
        {
            DescriptionAttribute attribute = Type
                .GetType()
                .GetField(Type.ToString())
                ?.GetCustomAttribute<DescriptionAttribute>();

            return attribute?.Description ?? Type.ToString();
        }

    }
}
