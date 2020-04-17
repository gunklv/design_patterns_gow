namespace Command.Commands
{
    public class CookSoupCommand : Command
    {
        private readonly Cook1 _cook;

        public CookSoupCommand(Cook1 cook)
        {
            _cook = cook;
        }

        public override void Excecute()
        {
            _cook.CookSoup();
        }

        public override void UnExecute()
        {
            throw new System.NotImplementedException();
        }
    }
}
