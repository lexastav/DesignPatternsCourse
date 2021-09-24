using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Pattern
{
    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Panel house is built!");
        }
    }
}
