using Mediator.Chatroom;
using System;

namespace Mediator
{
    class Program
    {
        static void Main()
        {
            var chatroom = new Chatroom.Chatroom();

            var bela = new Developer("Béla");
            var geza = new Developer("Géza");
            var lajos = new Manager("Lajos");

            chatroom.Register(bela);
            chatroom.Register(geza);
            chatroom.Register(lajos);

            bela.Send("Lajos", "Hi Lajos!");
            lajos.Send("Géza", "What's up Géza?");

            Console.ReadLine();
        }
    }
}
