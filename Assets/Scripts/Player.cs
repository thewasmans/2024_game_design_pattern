using System;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;


public class Model
{
    private string[] locations = new string[]{"A", "B", "C", "D"};
    private string currentLocation;
    public event Action LocationChange;

    public void SetLocation(string location)
    {
        if(!location.Contains(location))throw new System.Exception("Location not exist");

        currentLocation = location;
        
        LocationChange.Invoke();
    }
}

public class Player : MonoBehaviour
{
    public SOEvent SOEvent;

    private void Start()
    {
        SOEvent.Action += (Vector3 position) =>
        {
            transform.position = position;
        };
    }
}
