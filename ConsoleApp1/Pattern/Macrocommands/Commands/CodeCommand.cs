using C.Command.Pattern.Macrocommands.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Command.Pattern.Macrocommands.Commands
{
    class CodeCommand : ICommand
    {
        Programmer programmer;
        public CodeCommand(Programmer proger)
        {
            programmer = proger;
        }
        public void Execute()
        {
            programmer.StartCoding();
        }
        public void Undo()
        {
            programmer.StopCoding();
        }
    }
}
