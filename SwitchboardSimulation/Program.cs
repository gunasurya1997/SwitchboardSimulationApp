using SwitchboardSimulation;

class Program
{
    static void Main(string[] args)
    {
        // Use the initializer to set up the switchboard
        Switchboard switchboard = SwitchboardSetup.SetupSwitchboard();

        // Start the switchboard simulation
        SwitchboardController.Start(switchboard);
    }
}
