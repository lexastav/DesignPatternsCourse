﻿using F.State.Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.State.Pattern.States
{
    class LiquidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем жидкость в пар");
            water.State = new GasWaterState();
        }
        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем жидкость в лед");
            water.State = new SolidWaterState();
        }
    }
}
