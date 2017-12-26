using System;
using System.Collections.Generic;

namespace ChatRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Chatroom chatroom = new Chatroom();

            Participant George = new Male("George");
            Participant Jasmine = new Female("Jasmine");
            Participant Ringo = new Male("Ringo");
            Participant John = new Male("John");
            Participant Paul = new Male("Paul");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Jasmine);

            Jasmine.Send("John", "Hi John!");
            George.Send("Ringo", "Hi Ringo! How are you!");
            Ringo.Send("George", "Hi George!");
            Paul.Send("John", "Hi everyone!");
            John.Send("George", "My homies in one place!!");

            Console.ReadKey();
        }
    }
}
