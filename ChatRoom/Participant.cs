using System;
using System.Collections.Generic;
using System.Text;

namespace ChatRoom
{
    abstract class Participant
    {
        private string _name;
        public string Name
        {
            get { return _name; }
        }

        private AbstractChatroom _chatroom;
        public AbstractChatroom Chatroom
        {
            set { _chatroom = value; }
            get { return _chatroom; }
        }

        public Participant(string name)
        {
            _name = name;
        }

        public void Send(string to, string message)
        {
            _chatroom.Send(_name, to, message);
        }

        public abstract void Receive(string from, string message);
        public abstract void Notify(string from);
    }
}
