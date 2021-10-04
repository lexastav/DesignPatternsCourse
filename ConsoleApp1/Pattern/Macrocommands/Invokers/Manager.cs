using C.Command.Pattern.Macrocommands.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Command.Pattern.Macrocommands.Invokers
{
    class Manager
    {
        ICommand command;
        public void SetCommand(ICommand c)
        {
            command = c;
        }
        public void StartProject()
        {
            if (command != null)
            {
                command.Execute();
            }
        }
        public void StopProject()
        {
            if (command != null)
            {
                command.Undo();
            }
        }
    }
}
