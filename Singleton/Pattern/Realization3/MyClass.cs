using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C.Singleton.Pattern.Realization3
{
    public class MyClass
    {
        public static string text = "Hello World";
        public string Date { get; private set; }

        private MyClass()
        {
            Console.WriteLine($"MyClass ctor {DateTime.Now.TimeOfDay}");
            Date = DateTime.Now.TimeOfDay.ToString();
        }

        public static MyClass GetInstance()
        {
            Console.WriteLine($"GetInstance {DateTime.Now.TimeOfDay}");
            Thread.Sleep(500);
            return Nested.instance;
        }
        // внутренний класс куда мы поместили статическую переменную, представляющую объект синглтона. Так же у него будет конструктор.
        private class Nested
        {
            static Nested() { }
            internal static readonly MyClass instance = new MyClass();
        }
    }
}
