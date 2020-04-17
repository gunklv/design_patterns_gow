namespace State.Mobile
{
    public class VibrationState : MobileState
    {
        public override void updateState(Mobile mobile)
        {
            System.Console.WriteLine("Changed to silent mode!");
            mobile.setState(new SilentState());
        }
    }
}
