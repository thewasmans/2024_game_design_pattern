using UnityEngine;

public interface ICommand
{
    public void Execute(float deltaTime);
    public void Undo();
    public bool IsComplete();
}