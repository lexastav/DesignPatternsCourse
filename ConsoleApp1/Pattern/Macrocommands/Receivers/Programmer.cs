using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Command.Pattern.Macrocommands.Receivers
{
    class Programmer
    {
        public void StartCoding()
        {
            Console.WriteLine("Программист начинает писать код");
        }
        public void StopCoding()
        {
            Console.WriteLine("Программист завершает писать код");
        }
    }
}
