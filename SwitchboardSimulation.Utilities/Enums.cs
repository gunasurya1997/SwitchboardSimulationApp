using System.ComponentModel;

namespace SwitchboardSimulation.Utilities
{
    public class Enums
    {
        public enum ApplianceType
        {
            Fan,
            [Description("Air Conditioner")]
            AC,
            Bulb
        }
        public enum State
        {
            Off,
            On
        }
    }
}
