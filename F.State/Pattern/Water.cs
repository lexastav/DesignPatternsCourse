using F.State.Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.State.Pattern
{
    class Water
    {
        public IWaterState State { get; set; }
        public Water(IWaterState waterState)
        {
            State = waterState;
        }
        public void Heat()
        {
            State.Heat(this);
        }
        public void Frost()
        {
            State.Frost(this);
        }
    }
}
