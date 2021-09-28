using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Prototype.Pattern
{
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
}
