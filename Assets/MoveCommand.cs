using UnityEngine;

public class MoveCommand : ICommand
{
    private PlayerMover playerMover;
    private Vector3 direction;
    private bool normalize;

    public MoveCommand(PlayerMover playerMover, Vector3 direction, bool normalize = true)
    {
        this.playerMover = playerMover;
        this.normalize = normalize;
        this.direction = direction;
    }
    
    public void Execute()
    {
        var dir = normalize ? direction.normalized : direction;
        playerMover.Move(dir);
    }

    public void Undo()
    {
        var dir = normalize ? direction.normalized : direction;
        playerMover.Move(-dir);
    }
}