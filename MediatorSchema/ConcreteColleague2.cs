using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorSchema
{
    class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator) { }

        public override void Send(string message)
        {
            mediator.Send(message, this);
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Colleague2 gets message: " + message);
        }
    }
}
