using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CommandInvoker
{
    private static Stack<ICommand> undoStack = new Stack<ICommand>();
    private static Queue<ICommand> queueCommands = new Queue<ICommand>();
    private static ICommand currentCommand;

    public static List<ICommand> QueueCommands
    {
        get {return queueCommands.ToList();}
    }

    public static ICommand CurrentCommand
    {
        get {return currentCommand;}
    }

    public static void PushCommand(ICommand command)
    {
        queueCommands.Enqueue(command);
    }

    public static void ExecuteCommand()
    {
        if(currentCommand == null)
        {
            if(queueCommands.Count > 0)
            {
                currentCommand = queueCommands.Dequeue();
            }
        }
        if(currentCommand != null)
        {
            if(currentCommand.IsComplete())
            {
                undoStack.Push(currentCommand);
                currentCommand = null;
            }
            else
            {
               currentCommand.Execute(Time.deltaTime); 
            }
        }
    }

    public static void UndoCommand()
    {
        if(undoStack.Count > 0) undoStack.Pop().Undo();
    }
}