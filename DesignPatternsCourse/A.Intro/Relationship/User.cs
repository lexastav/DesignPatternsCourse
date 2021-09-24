using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCourse.A.Intro.Relationship
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Manager : User
    {
        public string Company { get; set; }
    }
}
