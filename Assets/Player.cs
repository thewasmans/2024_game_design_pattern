using System;

public interface Iturnable
{
    public void TurnableLeft();
    public void TurnableRight();
}

public interface IMovable
{
    public void GoForward();
    public void Move();
}

public abstract class RoadVehicule : Iturnable, IMovable
{
    public void GoForward()
    {
        throw new NotImplementedException();
    }

    public void Move()
    {
        throw new NotImplementedException();
    }

    public void TurnableLeft()
    {
        throw new NotImplementedException();
    }

    public void TurnableRight()
    {
        throw new NotImplementedException();
    }
}

public abstract class RailVehicule : IMovable
{
    public void GoForward()
    {
        throw new NotImplementedException();
    }

    public void Move()
    {
        throw new NotImplementedException();
    }
}

public class Car : RoadVehicule
{

}

public class Train : RailVehicule
{

}