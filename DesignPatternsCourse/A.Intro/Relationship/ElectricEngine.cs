using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCourse.A.Intro.Relationship
{
    public class ElectricEngine
    {
    }

    public class Car1
    {
        ElectricEngine engine;
        public Car1()
        {
            engine = new ElectricEngine();
        }
        public void GetEngineType()
        {
            Console.WriteLine(engine);
        }
    }
}
