namespace State.Mobile
{
    public class NormalState : MobileState
    {
        public override void updateState(Mobile mobile)
        {
            System.Console.WriteLine("Changed to vibration mode!");
            mobile.setState(new VibrationState());
        }
    }
}
