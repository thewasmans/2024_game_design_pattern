using System;
using UnityEngine;

[CreateAssetMenu(fileName = "SOEvent", menuName = "SOEvent", order = 0)]
public class SOEvent : ScriptableObject
{
    public event Action<Vector3> Action;
    public Vector3 Location;

    public void Raise(Vector3 location)
    {
        Location = location;
        Action.Invoke(location);
    }
}