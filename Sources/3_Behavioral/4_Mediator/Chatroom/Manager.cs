using System;

namespace Mediator.Chatroom
{
    public class Manager : Participant
    {
        public Manager(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a Manager: ");
            base.Receive(from, message);
        }
    }
}
