﻿using System.Collections.Generic;

namespace SwitchboardSimulation
{
    public class Switchboard
    {
        public List<Switch> Switches { get; }

        public Switchboard()
        {
            Switches = new List<Switch>();
        }

        public void AddSwitch(Switch switchToAdd)
        {
            Switches.Add(switchToAdd);
        }

    }
}
