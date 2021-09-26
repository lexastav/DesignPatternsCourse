using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Singleton.Pattern.Realization2
{
    public class SingleTon
    {
        private static readonly SingleTon instance = new SingleTon();

        public string Date { get; private set; }

        private SingleTon()
        {
            Date = DateTime.Now.TimeOfDay.ToString();
        }

        public static SingleTon GetInstance()
        {
            return instance;
        }
    }
}
