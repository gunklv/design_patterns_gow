namespace Command.Commands
{
    public class CreateHamburgerCommand : Command
    {
        private readonly Cook2 _cook;

        public CreateHamburgerCommand(Cook2 cook) {
            _cook = cook;
        }

        public override void Excecute()
        {
            _cook.CreateBurger();
        }

        public override void UnExecute()
        {
            throw new System.NotImplementedException();
        }
    }
}
