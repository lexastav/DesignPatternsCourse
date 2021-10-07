using F.State.Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.State.Pattern.States
{
    class GasWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Повышаем температуру пара");
        }
        public void Frost(Water water)
        {
            Console.WriteLine("Превпащаем пар в жидкость");
            water.State = new LiquidWaterState();
        }
    }
}
