using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCourse.A.Intro.InrefacesAndAbstractClasses.AbstractClasses
{
    //Тут все просто, абстрактный класс определяет метод, а наследники его реализуют. Но для данного случая более
    //предпочтительно было бы реализовать интерфейс, так как мы переопределяем поведение.

    public abstract class Vehicle
    {
        public abstract void Move();
    }

    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("The car is moving");
        }
    }

    public class Bus : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("The bus is moving");
        }
    }

    public class Truck : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("The truck is moving");
        }
    }
}
