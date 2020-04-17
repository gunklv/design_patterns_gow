using System;
using System.Collections.Generic;
using System.Linq;

namespace Instatopic.Observer
{
    public class Follower : User
    {
        private string _name;
        private List<string> _posts;

        public Follower(string name)
        {
            _name = name;
        }

        public override void Update()
        {
            _posts = _topic.Posts;
            Console.WriteLine("Observer {0}'s new state is {1}", _name, _posts.Last());
        }
    }
}
