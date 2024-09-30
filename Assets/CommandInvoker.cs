using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker
{
    public static Stack<ICommand> undoStack = new Stack<ICommand>();

    public static void ExecuteCommand(ICommand command)
    {
        command.Execute();
        undoStack.Push(command);
    }

    public static void UndoCommand()
    {
        undoStack.Pop();
    }
}