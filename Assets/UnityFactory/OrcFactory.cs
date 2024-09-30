using UnityEngine;

namespace FactoryUnity
{
    public abstract class Factory : MonoBehaviour
    {
        public abstract IEnemy GetEnemy<T>(Vector3 position);
    }

    public interface IEnemy
    {
        public string NameEnemy{get; set;}
        public void Initialize();
    }
    
    public class OrcFactory : Factory
    {
        public Orc orcPrefab;

        public override IEnemy GetEnemy<T>(Vector3 position)
        {
            GameObject instance = Instantiate(orcPrefab.gameObject, position, Quaternion.identity);
            IEnemy newEnemy = instance.GetComponent<IEnemy>();
            
            newEnemy.Initialize();
            return newEnemy;
        }
    }   
}