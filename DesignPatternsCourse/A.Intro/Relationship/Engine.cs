using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCourse.A.Intro.Relationship
{
    public abstract class Engine
    {
    }

    public class Car2
    {
        Engine engine1;
        public Car2(Engine eng)
        {
            engine1 = eng;
        }
    }
}
