using System;
using System.Collections.Generic;
using System.Text;

namespace ChatRoom
{
    class Female : Participant
    {
        public Female(string name) : base(name) { }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }

        public override void Notify(string from)
        {
            Console.WriteLine("Woman " + Name + " gets message from: " + from);
        }
    }
}
