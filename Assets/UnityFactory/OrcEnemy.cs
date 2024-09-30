using UnityEngine;

namespace FactoryUnity
{
    public class Orc : MonoBehaviour, IEnemy
    {
        public string NameEnemy { get; set; }

        public void Initialize()
        {
            name = NameEnemy;
        }
    }
}