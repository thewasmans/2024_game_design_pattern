using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public PlayerMover playerMover;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) RunPlayerCommand(Vector3.forward);
        if (Input.GetKeyDown(KeyCode.S)) RunPlayerCommand(Vector3.back); 
        if (Input.GetKeyDown(KeyCode.Q)) RunPlayerCommand(Vector3.left);
        if (Input.GetKeyDown(KeyCode.D)) RunPlayerCommand(Vector3.right);
        if (Input.GetKeyDown(KeyCode.Backspace)) OnUndoInput();
        CommandInvoker.ExecuteCommand();
    }
    
    public void RunPlayerCommand(Vector3 direction)
    {
        CommandInvoker.PushCommand(new MoveCommand(playerMover, direction));
    }

    public void OnUndoInput()
    {
        CommandInvoker.UndoCommand();
    }
}