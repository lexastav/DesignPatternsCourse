using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Command.Pattern.Macrocommands.Commands
{
    class MacroCommand : ICommand
    {
        List<ICommand> commands;
        public MacroCommand(List<ICommand> mcm)
        {
            commands = mcm;
        }
        public void Execute()
        {
            foreach(ICommand c in commands)
            {
                c.Execute();
            }
        }
        public void Undo()
        {
            foreach (ICommand c in commands)
            {
                c.Undo();
            }
        }
    }
}
