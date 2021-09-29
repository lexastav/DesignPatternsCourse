using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Builder.Pattern.Builders
{
    class CraftBreadBuilder : BreadBuilder
    {
        public override void SetFlour()
        {
            this.Bread.Flour = new Flour
            {
                Sort = "Кукурузная мука высший сорт"
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
            this.Bread.Eggs = new Eggs
            {
                Count = 2
            };
        }
        public override void SetAdditives()
        {
            this.Bread.Additives = new Additives
            {
                Name = "Улучшитель для хлеба"
            };
        }
    }
}
