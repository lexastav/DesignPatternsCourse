using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Strategy.Pattern
{
    class ElectricType : IEngineTypeble
    {
        public void TypeEngine()
        {
            Console.WriteLine("Ездит на электричесстве");
        }
    }
}
