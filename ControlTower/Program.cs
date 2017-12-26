using System;
using System.Collections.Generic;

namespace ControlFlight
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlTower controltower = new ControlTower();

            Machine helicopter = new Helicopter();
            Machine sailplane = new SailPlane();
            Machine hunter = new Hunter();

            controltower.Register(helicopter);
            controltower.Register(sailplane);
            controltower.Register(hunter);

            helicopter.SendControlMessage();
            sailplane.SendControlMessage();
            hunter.SendControlMessage();

            Console.ReadKey();
        }
    }
}
