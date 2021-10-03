using C.Command.Pattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Command.Pattern.Commands
{
    class VolumeCommand : ICommand
    {
        Volume volume;
        public VolumeCommand(Volume vol)
        {
            volume = vol;
        }
        public void Execute()
        {
            volume.RaiseLevel();
        }
        public void Undo()
        {
            volume.DropLevel();
        }
    }
}
