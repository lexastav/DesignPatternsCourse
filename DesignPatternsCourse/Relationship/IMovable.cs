using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCourse.A.Intro.Relationship
{
    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move() => Console.WriteLine("Машина едет");
    }
}
