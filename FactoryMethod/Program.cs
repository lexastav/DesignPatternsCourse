using System;
using FactoryMethod.Pattern;

namespace FactoryMethod
{
    class Program
    {
        // А вот теперь самое интересное. Фабричный метод- это паттерн, который определяет интерфейс для создания
        // объектов некоторого класса, но непосредственно решение о том, объект какого класса создавать происходит в
        // подклассах. То есть паттерн предполагает, что базовый класс делегирует создание объектов классам-наследникам.

        // Предположим нам нужно построить дом, но дома бывают разные, как и строители, которые специализируются
        // на строительстве домов из определенных материалов. Нам сперва нужно построить панельный дом. В базовом
        // абстрактном классе строителя мы определяем метод построики дома, который должен будет реализовать подрядчик,
        // специализирующийся на строительстве панельных домов. Соответственно у абстрактного базового класса дом есть
        // класс наследник- панельный дом, который и будет построен подрядчиком специализирующимся на панельных домах.
        // Аналогично если нам нужен деревянный дом и тд.

        //То есть от сюда выходит, что данный паттерн надо применять:
        //1) Если заранее неизвестно, объекты каких типов нужно создавать;
        //2) Когда система должна быть независимой от процесса создания новых объектов и расширяемой, то есть в нее
        //   можно легко вводить новые классы, объекты которых система должна создавать;
        //3) Когда создание новых объектов необходимо делегировать из базового класса классам наследникам.

        //Ну и сразу же очевидные недостатки. Для каждого нового продукта необходимо так же создавать и свой класс
        //подрядчика, что может привести к загромаждению кода в больших проектах.
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
