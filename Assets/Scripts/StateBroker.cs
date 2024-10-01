using System.Collections.Generic;

public class StatBroker
{
    public List<IModifier> Modifiers = new();

    public void AddModifier(IModifier modifier)
    {
        Modifiers.Add(modifier);
    }

    public void RemoveModifier(IModifier modifier)
    {
        Modifiers.Remove(modifier);
    }

    public float Process(Stat stat)
    {
        stat.ModifiedValue = stat.Value;
        
        foreach (IModifier modifier in Modifiers)
        {
            modifier.Modify(stat);
        }

        return stat.ModifiedValue;
    }
}