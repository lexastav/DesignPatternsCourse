using System;
using FactoryMethod.Pattern;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new PanelDevrloper("ООО Рога и копыта");
            Console.WriteLine(dev.Name);
            House panelHouse = dev.Create();
            Console.ReadLine();
            dev = new WoodDeveloper("ИП Голожопенко");
            Console.WriteLine(dev.Name);
            House woodHouse = dev.Create();
        }
    }
}
