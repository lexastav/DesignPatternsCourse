using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.TemplateMethod.Pattern
{
    class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Сдаем вступительные экзамены и поступаем в вуз");
        }
        public override void Study()
        {
            Console.WriteLine("Посещае лекции");
            Console.WriteLine("Проходим практику");
        }
        public override void PassExams()
        {
            Console.WriteLine("Сдаем экзамены по специальности");
        }
        public override void GetDocument()
        {
            Console.WriteLine("Получаем диплом о высшем образовании");
        }
    }
}
