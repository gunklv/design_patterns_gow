namespace State.Mobile
{
    public class SilentState : MobileState
    {
        public override void updateState(Mobile mobile)
        {
            System.Console.WriteLine("Changed to normal mode!");
            mobile.setState(new NormalState());
        }
    }
}
