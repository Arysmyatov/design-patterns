using System.Collections.Generic;
using System.Text;
using Dp_Command.Commands;

namespace Dp_Command.Commands.RemoteControls
{

    public class RemoteControl
    {
        private Dictionary<int, ICommand> _commands;

        public RemoteControl()
        {
            _commands = new Dictionary<int, ICommand>();
        }

        public void PushButton(int buttonId)
        {
            if (_commands.ContainsKey(buttonId))
                _commands[buttonId].Execute();
        }
        
        public void SetCommandForButton(int buttonId, ICommand cmd)
        {
            _commands[buttonId] = cmd;
        }

        
        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var buttonId in _commands.Keys)
                sb.AppendFormat("{0} \t- {1}\n", buttonId, _commands[buttonId]);

            sb.Append("other. \t- Exit");

            return sb.ToString();
        }
    }

}