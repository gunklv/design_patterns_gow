using System;

namespace Mediator.Chatroom
{
    public class Developer : Participant
    {
        public Developer(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a Developer: ");
            base.Receive(from, message);
        }
    }
}
