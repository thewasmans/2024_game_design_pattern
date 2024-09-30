public interface IMovable
{
    public void Move();
}

public interface IJumpable
{
    public void Jump();
}

public class Soldier : IMovable, IJumpable
{
    public float MoveSpeed { get; set; }
    public float Acceleration { get; set; }

    public void Jump()
    {
    }

    public void Move()
    {
    }
}