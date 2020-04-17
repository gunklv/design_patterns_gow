namespace Instatopic.Observer
{
    public class InterestingTopic : Topic
    {
        public override void Attach(User observer)
        {
            base.Attach(observer);
            observer._topic = this;
        }
    }
}
