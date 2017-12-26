using System;
using System.Collections.Generic;
using System.Text;

namespace ControlFlight
{
    class Helicopter : Machine
    {
        public Helicopter() : base("Helicopter")
        { }

        public override void SendControlMessage()
        {
            Console.WriteLine("Helicopter Configuration");
            _controltower.SendControlMessage(_typemachine);
        }
    }
}
