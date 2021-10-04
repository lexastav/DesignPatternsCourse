using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Command.Pattern.Macrocommands.Commands
{
    interface ICommand
    {
        void Execute();
        void Undo();

    }
}
