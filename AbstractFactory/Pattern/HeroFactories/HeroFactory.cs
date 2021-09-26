using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.AbstractFactory.Pattern.HeroFactories
{
    abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }
}
