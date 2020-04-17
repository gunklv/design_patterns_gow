using System.Collections.Generic;

namespace Instatopic.Observer
{
    public abstract class Topic
    {
        private List<User> _observers = new List<User>();
        public List<string> Posts { get; set; } = new List<string>();

        public virtual void Attach(User observer)
        {
            _observers.Add(observer);
        }

        public void Detach(User observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(var o in _observers)
            {
                o.Update();
            }
        }
    }
}
