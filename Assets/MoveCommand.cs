using UnityEngine;

public class MoveCommand : ICommand
{
    private PlayerMover playerMover;
    private Vector3 direction;
    private bool normalize;
    private const float maxTime = 1;
    private float currentTime;

    public Vector3 Direction { get => direction;}
    public float CurrentTime { get => currentTime;}

    public MoveCommand(PlayerMover playerMover, Vector3 direction, bool normalize = true)
    {
        this.playerMover = playerMover;
        this.normalize = normalize;
        this.direction = direction;
        currentTime = 0;
    }
    
    public void Execute(float deltaTime)
    {
        var dir = normalize ? Direction.normalized : Direction;
        playerMover.Move(dir * deltaTime);
        currentTime+=deltaTime;
    }

    public bool IsComplete()
    {
        return currentTime >= maxTime;
    }

    public void Undo()
    {
        var dir = normalize ? Direction.normalized : Direction;
        playerMover.Move(-dir);
    }
}