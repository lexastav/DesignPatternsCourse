using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Pattern
{
    //адстрактный класс строительной компании
    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string name)
        {
            Name = name;
        }
        abstract public House Create();
    }
}
