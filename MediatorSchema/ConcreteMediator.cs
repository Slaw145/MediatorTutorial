using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorSchema
{
    abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }

    class ConcreteMediator : Mediator
    {
        private Colleague _colleague1;
        private Colleague _colleague2;

        public Colleague Colleague1
        {
            set { _colleague1 = value; }
        }

        public Colleague Colleague2
        {
            set { _colleague2 = value; }
        }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == _colleague1)
            {
                _colleague2.Notify(message);
            }
            else

            {
                _colleague1.Notify(message);
            }
        }
    }
}
