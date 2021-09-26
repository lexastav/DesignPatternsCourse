using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCourse.A.Intro.InrefacesAndAbstractClasses.AbstractClasses
{
    //В данном случе реалзуя интерфейс, мы обязуем некие классы реализовать определенное поведение. При этом классы
    //могут вообще никак не зависеть друг от друга.
    public interface IMovable
    {
        void Move();
    }

    public abstract class Animal 
    {
        
    }

    public class Aircraft : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The aircraft is flying");
        }
    }

    public class Hourse : Animal, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Horse ridding");
        }
    }
}
