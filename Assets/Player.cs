public interface ISwitchtable
{
    void Actidate();
    void Deactidate();
    void IsActivae();
}

public class Switch
{
    private ISwitchtable switchable;
}