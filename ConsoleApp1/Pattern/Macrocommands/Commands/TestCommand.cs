using C.Command.Pattern.Macrocommands.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Command.Pattern.Macrocommands.Commands
{
    class TestCommand : ICommand
    {
        Tester tester;
        public TestCommand(Tester t)
        {
            tester = t;
        }
        public void Execute()
        {
            tester.StartTest();
        }
        public void Undo()
        {
            tester.StopTest();
        }
    }
}
