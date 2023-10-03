namespace SwitchboardSimulation.Models
{
    public class Switch
    {
        public bool IsOn { get; private set; }
        public Appliance AssociatedAppliance { get; }

        public Switch(Appliance appliance)
        {
            IsOn = false;
            AssociatedAppliance = appliance;
        }

        public void Toggle()
        {
            IsOn = !IsOn;
        }
    }
}
