namespace Command.Commands
{
    public class BakeSteakCommand : Command
    {
        private readonly Cook1 _cook;

        public BakeSteakCommand(Cook1 cook)
        {
            _cook = cook;
        }

        public override void Excecute()
        {
            _cook.BakeSteak();
        }

        public override void UnExecute()
        {
            throw new System.NotImplementedException();
        }
    }
}
