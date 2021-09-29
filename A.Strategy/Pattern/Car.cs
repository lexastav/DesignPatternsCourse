using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Strategy.Pattern
{
    class Car
    {
        protected int passengers;
        protected string model;

        public Car(int passengers, string model, IEngineTypeble typeEngine)
        {
            this.passengers = passengers;
            this.model = model;
            EngineTypeble = typeEngine;
        }
        public IEngineTypeble EngineTypeble { private get; set; }
        public void TypeEngine()
        {
            EngineTypeble.TypeEngine();
        }
    }
}
