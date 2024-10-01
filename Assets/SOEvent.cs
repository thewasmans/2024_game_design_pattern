using System;
using UnityEngine;

[CreateAssetMenu(fileName = "SOEvent", menuName = "SOEvent", order = 0)]
public class SOEvent : ScriptableObject
{
    public event Action action;

    public void Raise()
    {
        action?.Invoke();
    }
}

[CreateAssetMenu(fileName = "SOEvent", menuName = "SOEvent<T>", order = 0)]
public abstract class SOEvent<T> : ScriptableObject
{
    public event Action<T> action;

    public void Raise(T t)
    {
        action?.Invoke(t);
    }   
}