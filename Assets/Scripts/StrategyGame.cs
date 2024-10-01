using UnityEngine;

public class StrategyGame : MonoBehaviour
{
    private void Start()
    {
        Unit LePen = new Unit();
        Unit Remy = new Unit();
        Unit Sarkozy = new Unit();

        LePen.SetAttackStrategy(new PowderAttack());
        Remy.SetAttackStrategy(new CryAttack());
        Sarkozy.SetAttackStrategy(new SmokeAttack());

        LePen.Attack();
        Remy.Attack();
        Sarkozy.Attack();
    }    
}