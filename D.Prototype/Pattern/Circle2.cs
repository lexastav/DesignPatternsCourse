using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace D.Prototype.Pattern
{
    [Serializable]
    class Circle2 : IFigure
    {
        int radius;
        public Point2 P { get; set; }
        public Circle2(int r, int x, int y)
        {
            radius = r;
            this.P = new Point2
            {
                X = x,
                Y = y
            };
        }
        public IFigure Clone()
        {
            return this.MemberwiseClone() as IFigure;
        }

        public object DeepCopy()
        {
            object figure = null;
            using (MemoryStream tmpStream = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter(null,
                    new StreamingContext(StreamingContextStates.Clone));

                binaryFormatter.Serialize(tmpStream, this);
                tmpStream.Seek(0, SeekOrigin.Begin);

                figure = binaryFormatter.Deserialize(tmpStream);
            }
            return figure;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Circle with radius: {radius} and center at point: ({P.X}, {P.Y}) created!");
        }
    }
}
