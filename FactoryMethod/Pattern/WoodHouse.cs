using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Pattern
{
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Wood house is built!");
        }
    }
}
