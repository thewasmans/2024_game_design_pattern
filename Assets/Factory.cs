namespace FactorySelf
{
    public interface IEnemy
    {
    }

    public class Orc : IEnemy
    {
    }

    public class Goblin : IEnemy
    {
    }

    public class FactoryEnemy
    {
        public static IEnemy GetEnemy<T>() where T : IEnemy, new()
        {
            return new T();
        }
    }

    public class FactorySelf
    {
        public void Test()
        {
            IEnemy enemyGoblin = FactoryEnemy.GetEnemy<Goblin>();
            IEnemy enemyOrc = FactoryEnemy.GetEnemy<Orc>();
        }
    }
}