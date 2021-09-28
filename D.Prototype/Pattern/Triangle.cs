using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Prototype.Pattern
{
    class Triangle : IFigure
    {
        int sideA;
        int sideB;
        int sideC;

        public Triangle(int a, int b, int c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }
        public IFigure Clone()
        {
            return new Triangle(this.sideA, this.sideB, this.sideC);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Triangle with sides: {sideA}, {sideB}, {sideC} created!");
        }
    }
}
