using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    public SOEvent soEvent;
    public SOEvent<string> soEventString;

    private void Start()
    {
        soEvent.Raise();
        soEventString.Raise("Bite");
    }

    private void OnEnable()
    {
        soEvent.action += () => PlayerActivated("");
        soEventString.action += (string message) => PlayerActivated(message);
    }

    private void PlayerActivated(string message)
    {
        Debug.Log("Player entered in the scene : " + message);
    }
    private void PlayerDesactivated(string message)
    {
        Debug.Log("Player entered in the scene :" + message);
    }

    private void OnDisable()
    {
        soEvent.action -= () => PlayerDesactivated("");
        soEventString.action -= (string message) => PlayerDesactivated(message);
    }
}
