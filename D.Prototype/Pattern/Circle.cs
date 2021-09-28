using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Prototype.Pattern
{
    class Circle : IFigure
    {

        int radius;
        public Point P { get; set; }
        public Circle(int r, int x, int y)
        {
            radius = r;
            this.P = new Point
            {
                X = x,
                Y = y
            };
        }

        public IFigure Clone()
        {
            return this.MemberwiseClone() as IFigure;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Circle with radius: {radius} and center at point: ({P.X}, {P.Y}) created!");
        }
    }
}
