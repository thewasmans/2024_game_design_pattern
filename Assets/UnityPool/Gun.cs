using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;

namespace UnityPool
{
    public class Gun : MonoBehaviour
    {
        public Projectile projectilePrefab;

        public IObjectPool<Projectile> ObjectPool;
        public bool CollectionCheck;
        public int DefaultCapacity;
        public int maxSize;

        void Start()
        {
            ObjectPool = new ObjectPool<Projectile>(
                CreateProjectile,
                OnGetFromPool,
                OnReleaseToPool,
                OnDestroyPooledProjectile,
                CollectionCheck,
                DefaultCapacity,
                maxSize
            );
        }

        public Projectile CreateProjectile()
        {
            Projectile instance = Instantiate(projectilePrefab);
            instance.ObjectPool = ObjectPool;
            return instance;
        }

        public void OnGetFromPool(Projectile projectile)
        {

        }
        
        public void OnReleaseToPool(Projectile projectile)
        {
            
        }

        public void OnDestroyPooledProjectile(Projectile projectile)
        {
            Destroy(projectile.gameObject);
        }

        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                ObjectPool.Get();
            }
        }
    }
}