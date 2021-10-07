using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Iterator.Pattern.Interfaces
{
    interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
}
