using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Builder.Pattern.Builders
{
    class RyeBreadBuilder : BreadBuilder
    {
        public override void SetFlour()
        {
            this.Bread.Flour = new Flour
            {
                Sort = "Ржаная мука высший сорт"
            };
        }
        public override void SetSalt()
        {
            this.Bread.Salt = new Salt();
        }
        public override void SetWater()
        {
            this.Bread.Water = new Water();
        }
        public override void SetEggs()
        {
           // не добавляем
        }
        public override void SetAdditives()
        {
            //не добавляем
        }
    }
}
