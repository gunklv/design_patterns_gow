namespace State.Mobile
{
    public class Mobile
    {
        private MobileState _currentState;

        public Mobile()
        {
            _currentState = new NormalState();
        }

        public void changeState()
        {
            _currentState.updateState(this);
        }

        public void setState(MobileState mobileState)
        {
            _currentState = mobileState;
        }
    }
}
