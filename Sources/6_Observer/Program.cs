using Instatopic.Observer;
using System;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            var topic = new InterestingTopic();

            var follower1 = new Follower("f1");
            var follower2 = new Follower("f2");
            var follower3 = new Follower("f3");

            topic.Attach(follower1);
            topic.Attach(follower2);
            topic.Attach(follower3);

            topic.Posts.Add("Hello everybody!");
            topic.Notify();

            Console.ReadLine();
        }
    }
}
