using C.Command.Pattern.Macrocommands.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Command.Pattern.Macrocommands.Commands
{
    class AdvertizeCommand : ICommand
    {
        Marketer marketer;
        public AdvertizeCommand(Marketer m)
        {
            marketer = m;
        }
        public void Execute()
        {
            marketer.StartAdvertize();
        }
        public void Undo()
        {
            marketer.StopAdvertize();
        }
    }
}
