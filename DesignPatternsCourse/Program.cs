using System;
using DesignPatternsCourse.A.Intro.Relationship;


namespace DesignPatternsCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }
        static void InhritanceClassic()
        {
            // Классическое наследование. В данном случае класс Manager наследуется от класса User, при этом
            // как бы расширяя его. Мы можем создавать объекты как класса User, так и класса Manager, а объекты
            // класса Manager так же являются объектами класса User.
            var manager = new Manager
            {
                Id = 1,
                Name = "Robert",
                Company = "Microsoft"
            };
            Console.WriteLine(manager.Id);
            Console.WriteLine(manager.Name);
            Console.WriteLine(manager.Company);

            Console.ReadLine();

            var user = new User
            {
                Id = 2,
                Name = "Klaus"
            };
            Console.WriteLine(user.Id);
            Console.WriteLine(user.Name);
        }
        static void InterfaceImplementation()
        {
            // Реализация интерфейса. Интерфейс- это особый класс, который декларирует поведение. Унаследовашись
            // от интерфейса мы как бы обязуемся реализовать поведение задекларированное в интерфейсе.
            var car = new Car();
            car.Move();
        }
        static void Association()
        {
            // Ассоциация. Это отношение при котором объекты одного типа неким образом связаны с объектами другого типа.
            // В частности игрок играет в команде спартак, то есть класс Player связан отношением ассоциации с классом
            // Spartak.
            var player = new Player
            {
                Name = "Alex",
                Team = new Spartak()
            };

            Console.WriteLine(player.Name);
            Console.WriteLine(player.Team);
        }
        static void AssociationComposition()
        {
            // Композиция. Частный случай ассоциации. Отношение типа "имеет", то есть в нашем случае класс Car1 содержит
            // объект класса ElectricEngine. При этом класс автомоболя полностью управляет жизненным циклом объекта
            // двигателя, то есть при уничтожении объекта автомобиля вместе сним будет уничтожен и объект двигателя.
            // Короче говоря объект автомобиля тут основной, а объект двигателя- зависимый.

            var car = new Car1();
            Console.WriteLine(car);
            car.GetEngineType();
        }
        static void AssociationAggregation()
        {
            //Агрегация. То же частный случай ассоциации и как в случае с композицией- это отношение типа "имеет", но
            //связь как бы слабая. То есть в данном случае объекты автомобиля и двигателя будут как бы равноправными.
            //В конструктор класса автомобиля передается ссылка на уже существующий объект двигателя. И, как правило,
            //определяется ссылка не на конкретный класс, а на абстрактный или интерфейс, что как бы является более гибким
            //подходом.
            Engine engine;
            Car2 car;
        }
    }
}
