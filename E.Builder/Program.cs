﻿using System;
using E.Builder.Pattern;
using E.Builder.Pattern.Builders;

namespace E.Builder
{
    //Строитель- пораждающий шаблон проектирования, который инкапсулирует создание объекта и позволяет разделить
    //его на различные этапы.

    //Ну вот например нам нужно выпечь хлеб. Хлеб может включать в себя множество компонентов. Вот и создаем классы,
    //представляющие компоненты и сам хлеб. Для пущего упрощения в классе хлеб используем класс StringBuilder.
    //Самое интересное, хлеб может иметь различную комбинацию компонентов, один сорт хлеба может содержать определенны
    //компонент, а другой может не содержать его вовсе. И нам нужно обеспечить выпечку разных сортов. И вот тут как раз
    //паттерн строитель расскрывает себя во всей красе. Нам понадобится абстрактный класс, который реализует один
    //единственный метод- создать хлеб, а так же задекларирует методы добавления компонентов. Конкретные классы-
    //строители реализуют эти методы, а класс пекаря выступает в роли распорядителя, который и будет вызывать эти методы
    //для создания конкретного хлеба.

    //Исходя из описанного кейса можно сделать вывод, что паттерн строитель лучше использовать:
    // 1) когда процесс создания нового объекта не должен зависеть от того, из каких частей этот объект состоит и
    //    какие части связаны между собой.
    // 2) Когда необходимо обеспечить получение различных вариаций объекта в процессе его создания.

    //Ну и минусом будет то, что если компонентов будет слишком много, а так же слишком много вариаций объекта-
    //это может внести значительную путанницу в код, так как придется создавать кучу классов.


    class Program
    {
        static void Main(string[] args)
        {
            Baker baker = new Baker();
            BreadBuilder breadBuilder = new WheatBreadBuilder();
            Bread wheatBread = baker.Bake(breadBuilder);
            Console.WriteLine(wheatBread.ToString());

            Console.ReadLine();

            breadBuilder = new RyeBreadBuilder();
            Bread ryeBread = baker.Bake(breadBuilder);
            Console.WriteLine(ryeBread.ToString());

            Console.ReadLine();

            breadBuilder = new CraftBreadBuilder();
            Bread craftBread = baker.Bake(breadBuilder);
            Console.WriteLine(craftBread.ToString());
        }
    }
}
