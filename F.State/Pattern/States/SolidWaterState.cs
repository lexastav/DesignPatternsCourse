using F.State.Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.State.Pattern.States
{
    class SolidWaterState : IWaterState
    {
        public void Heat (Water water)
        {
            Console.WriteLine("Превращаем лед в воду");
            water.State = new LiquidWaterState();
        }
        public void Frost(Water water)
        {
            Console.WriteLine("Продолжаем заморозку");
        }
    }
}
