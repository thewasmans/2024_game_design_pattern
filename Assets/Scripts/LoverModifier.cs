public class LoverModifier : IModifier
{
    public float Lover{get;set;}
    public string Type{get; private set;}

    public LoverModifier(float lover, string type)
    {
        Lover = lover;
        Type = type;
    }

    public void Modify(Stat lover)
    {
        if(lover.Type != Type) return;
        
        lover.ModifiedValue += Lover;
    }
}