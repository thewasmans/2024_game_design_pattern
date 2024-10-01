using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public StatBroker Broker = new StatBroker();
    public Stat Heart = new Stat(){Value = 13, Type = "Heart"};
    public Stat Seakness = new Stat(){Value = 69, Type = "Seakness"};

    private void Start()
    {
        Broker.AddModifier(new LoverModifier(42, "Des bisoux"));
        Broker.Process(Seakness);

        Debug.Log("Ear.ModifiedValue " + Seakness.ModifiedValue);
    }
}