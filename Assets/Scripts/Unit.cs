using UnityEngine;

public class Unit
{
    public IAttackStrategy AttackedStrategy;

    public void SetAttackStrategy(IAttackStrategy attacktrategy) => AttackedStrategy = attacktrategy;

    public void Attack() => AttackedStrategy?.Attack();
}