using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement
{
    public void Move()
    {
        Debug.Log("Move the player");
    }
}

public class PlayerSound
{
    public void PlaySound()
    {
        Debug.Log("Play sound from player");
    }
}

public class Player : MonoBehaviour
{
    public PlayerSound PlayerSound = new PlayerSound();
    public PlayerMovement PlayerMovement = new PlayerMovement();

    public void MovePlayer()
    {
        PlayerMovement.Move();
    }

    public void PlayPlayerSound()
    {
        PlayerSound.PlaySound();
    }

    void Start()
    {
        MovePlayer();
        PlayerSound.PlaySound();
    }
}
