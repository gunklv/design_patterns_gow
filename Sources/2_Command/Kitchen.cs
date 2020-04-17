using System.Collections.Generic;

namespace Command
{
    public class Kitchen
    {
        private List<Commands.Command> _commands = new List<Commands.Command>();

        public void AddRequest(Commands.Command command)
        {
            _commands.Add(command);
        }

        public void Cook()
        {
            foreach(var c in _commands)
            {
                c.Excecute();
            }
        }
    }
}
