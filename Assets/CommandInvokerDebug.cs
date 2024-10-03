using UnityEngine;
using System.Linq;

public class CommandInvokerDebug : MonoBehaviour
{
    public Vector3[] WaitCommands;
    public Vector3 CurrentDirection;

    [Range(0, 1)]
    public float CurrentTiming;

    void Update()
    {
        WaitCommands = CommandInvoker.QueueCommands.
        Select(c => c as MoveCommand).
        Where(c => c!= null).
        Select(c => c.Direction)
        .ToArray();

        MoveCommand currentCommand = CommandInvoker.CurrentCommand as MoveCommand;

        if(currentCommand != null)
        {
            CurrentDirection = currentCommand.Direction;
            CurrentTiming = currentCommand.CurrentTime;
        }
    }
}