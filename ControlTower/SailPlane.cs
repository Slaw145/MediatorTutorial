using System;
using System.Collections.Generic;
using System.Text;

namespace ControlFlight
{
    class SailPlane : Machine
    {
        public SailPlane() : base("Sailplane")
        { }

        public override void SendControlMessage()
        {
            Console.WriteLine("SailPlane Configuration");
            _controltower.SendControlMessage(_typemachine);
        }
    }
}
