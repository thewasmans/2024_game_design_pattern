using UnityEngine;
using UnityEngine.Pool;

namespace UnityPool
{
    public class Projectile : MonoBehaviour
    {
        public IObjectPool<Projectile> ObjectPool;
    }   
} 