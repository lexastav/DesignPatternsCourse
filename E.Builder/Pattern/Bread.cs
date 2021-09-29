using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Builder.Pattern
{
    class Bread
    {
        public Flour Flour { get; set; }
        public Salt Salt { get; set; }
        public Water Water { get; set; }
        public Eggs Eggs { get; set; }
        public Additives Additives { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (Flour != null)
            {
                stringBuilder.Append(Flour.Sort + "\n");
            }
            if (Salt != null)
            {
                stringBuilder.Append("Соль \n");
            }
            if (Water != null)
            {
                stringBuilder.Append("Вода \n");
            }
            if (Eggs != null)
            {
                stringBuilder.Append("Яйца: " + Eggs.Count + "шт. \n");
            }
            if (Additives != null)
            {
                stringBuilder.Append("Добавки: " + Additives.Name + "\n");
            }
            return stringBuilder.ToString();
        }
    }
}
