using System;
using System.Collections.Generic;
using System.Text;

namespace ControlFlight
{
    abstract class Machine
    {
        protected string _typemachine;
        public string TypeMachine
        {
            get { return _typemachine; }
        }

        protected TowerMediator _controltower;
        public TowerMediator Controltower
        {
            set { _controltower = value; }
            get { return _controltower; }
        }

        public Machine(string typemachine)
        {
            _typemachine = typemachine;
        }

        public abstract void SendControlMessage();
    }
}
