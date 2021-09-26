using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B.AbstractFactory.Pattern.HeroFactories;

namespace B.AbstractFactory.Pattern
{
    class Hero
    {
        private Weapon weapon;
        private Movement movement;
        public Hero(HeroFactory factory)
        {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
        }
        public void Run()
        {
            movement.Move();
        }
        public void Hit()
        {
            weapon.Hit();
        }
    }
}
