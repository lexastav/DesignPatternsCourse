using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.AbstractFactory.Pattern
{
    class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("We are running");
        }
    }
}
