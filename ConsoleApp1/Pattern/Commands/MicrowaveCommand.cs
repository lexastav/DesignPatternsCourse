using C.Command.Pattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Command.Pattern.Commands
{
    class MicrowaveCommand : ICommand
    {
        Microwave microwave;
        int time;
        public MicrowaveCommand(Microwave mw, int t)
        {
            microwave = mw;
            time = t;
        }
        public void Execute()
        {
            microwave.StartCooking(time);
            microwave.StopCooking();
        }
        public void Undo()
        {
            microwave.StopCooking();
        }
    }
}
