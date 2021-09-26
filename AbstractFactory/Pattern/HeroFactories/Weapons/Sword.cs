using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.AbstractFactory.Pattern
{
    class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("We hit with the sword");
        }
    }
}
