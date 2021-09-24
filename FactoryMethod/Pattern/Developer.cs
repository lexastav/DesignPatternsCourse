using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Pattern
{
    //абстрактный класс строительной компании
    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string name)
        {
            Name = name;
        }
        // собственно сам фабричный метод
        abstract public House Create();
    }
}
