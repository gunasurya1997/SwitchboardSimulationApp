using System.ComponentModel;

namespace SwitchboardSimulation.Utilities
{
    public class Enums
    {
        public enum ApplianceType
        {
            [Description("Fan")]
            Fan,
            [Description("Air Conditioner")]
            AC,
            [Description("Lamp")]
            Bulb
        }
        public enum State
        {
            Off,
            On
        }
    }
}
