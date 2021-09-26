using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Singleton.Pattern.Realization4
{
    public class MyClass2
    {
        private static readonly Lazy<MyClass2> lazy = new Lazy<MyClass2>(() => new MyClass2());

        public string Name { get; private set; }

        private MyClass2()
        {
            Name = Guid.NewGuid().ToString();
        }

        public static MyClass2 GetInstance()
        {
            return lazy.Value;
        }
        
    }
}
