using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Builder.Pattern.Builders
{
    class Baker
    {
        public Bread Bake(BreadBuilder breadBuilder)
        {
            breadBuilder.CreateBread();
            breadBuilder.SetFlour();
            breadBuilder.SetSalt();
            breadBuilder.SetWater();
            breadBuilder.SetEggs();
            breadBuilder.SetAdditives();
            return breadBuilder.Bread;
        }
    }
}
