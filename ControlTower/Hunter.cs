using System;
using System.Collections.Generic;
using System.Text;

namespace ControlFlight
{
    class Hunter : Machine
    {
        public Hunter() : base("Hunter")
        { }

        public override void SendControlMessage()
        {
            Console.WriteLine("Hunter Configuration");
            _controltower.SendControlMessage(_typemachine);
        }
    }
}
