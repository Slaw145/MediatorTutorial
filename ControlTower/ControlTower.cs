using System;
using System.Collections.Generic;
using System.Text;

namespace ControlFlight
{
    abstract class TowerMediator
    {
        public abstract void Register(Machine machine);
        public abstract void SendControlMessage(string typeMachine);
    }

    class ControlTower : TowerMediator
    {
        private Dictionary<string, Machine> _machines = new Dictionary<string, Machine>();

        public override void Register(Machine machine)
        {
            if (!_machines.ContainsValue(machine))
            {
                _machines[machine.TypeMachine] = machine;
            }

            machine.Controltower = this;
        }

        public override void SendControlMessage(string typeMachine)
        {
            Machine machine = _machines[typeMachine];

            if (machine != null)
            {
                Console.WriteLine("Control the flight of a {0}", machine.TypeMachine);
            }
        }
    }
}
