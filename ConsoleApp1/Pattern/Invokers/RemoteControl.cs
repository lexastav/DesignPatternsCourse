using C.Command.Pattern.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Command.Pattern.Invokers
{
    class RemoteControl
    {
        ICommand[] buttons;
        Stack<ICommand> commandsHistory;
        public RemoteControl() 
        {
            buttons = new NoCommand[2];
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new NoCommand();
            }
            commandsHistory = new Stack<ICommand>();
        }

        public void SetCommand(int number, ICommand cm)
        {
            buttons[number] = cm;
        }
        public void PressButton(int number)
        {
            buttons[number].Execute();
            commandsHistory.Push(buttons[number]);
        }
        public void PressUndo()
        {
            if (commandsHistory.Count > 0)
            {
                ICommand undoCommand = commandsHistory.Pop();
                undoCommand.Undo();
            }
        }
    }
}
