using System;
using System.Collections.Generic;
using System.Text;

namespace ChatRoom
{
    class Male : Participant
    {
        public Male(string name) : base(name) { }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }

        public override void Notify(string from)
        {
            Console.WriteLine("Man " + Name + " gets message from: " + from);
        }
    }
}
