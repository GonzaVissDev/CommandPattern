using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker
{
    Stack<ICommand> _commandList;

    public Invoker()
    {
        _commandList = new Stack<ICommand>();
    }

    public void AddCommand(ICommand newCommand)
    {
        newCommand.Execute();
        _commandList.Push(newCommand);
    }

    public void UndoCommand()
    {
        if (_commandList.Count > 0)
        {
            ICommand lastest_command = _commandList.Pop();
            lastest_command.Undo();
        }
    }
}

