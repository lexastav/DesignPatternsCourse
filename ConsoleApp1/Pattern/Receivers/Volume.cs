using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Command.Pattern.Receivers
{
    class Volume
    {
        public const int OFF = 0;
        public const int HIGHT = 100;
        private int level;

        public Volume()
        {
            level = OFF;
        }
        public void RaiseLevel()
        {
            if (level < HIGHT)
            {
                level++;
            }
            Console.WriteLine($"Уровень звука: {level}");
        }
        public void DropLevel()
        {
            if (level > OFF)
            {
                level--;
            }
            Console.WriteLine($"Уровень звука: {level}");
        }
    }
}
