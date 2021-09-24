using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Pattern
{
    // строит панельные дома
    class PanelDevrloper : Developer
    {
        public PanelDevrloper(string name) : base(name)
        {

        }
        public override House Create()
        {
            return new PanelHouse();
        }
    }
}
