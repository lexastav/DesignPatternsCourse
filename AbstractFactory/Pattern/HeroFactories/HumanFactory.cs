using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.AbstractFactory.Pattern.HeroFactories
{
    class HumanFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
