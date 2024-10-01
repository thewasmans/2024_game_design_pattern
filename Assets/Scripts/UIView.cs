using UnityEngine;
using UnityEngine.UI;

public class UIView : MonoBehaviour
{
    public Button[] buttons;
    public Button buttonTeleport;
    public Sprite DefaultSprite;
    public Sprite SelectedSprite;
    public Sprite TeleportSprite;
    public string locationSelected;
    public Button buttonSelected;
    public SOEvent SOEvent;
    public Vector3 Position;

    private void Start()
    {
        foreach (var button in buttons)
        {
            Text text = button.GetComponentInChildren<Text>();
            button.onClick.AddListener(() => SelectLocation(button, text.text));
        }
        buttonTeleport.onClick.AddListener(Teleportation);
    }

    public void Teleportation()
    {
        SOEvent.Raise(Position);
        UpdatePlayerPosition();
    }

    public void UpdatePlayerPosition()
    {
        buttonSelected.GetComponent<Image>().sprite = TeleportSprite;
    }

    public void SelectLocation(Button button,string location)
    {
        if(buttonSelected)
        {
            buttonSelected.GetComponent<Image>().sprite = DefaultSprite;
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            bool hitted = Physics.Raycast(ray, out hitInfo);

            if(hitted)
            {
                Position = hitInfo.point;
            }
        }
        buttonSelected = button;
        button.GetComponent<Image>().sprite = SelectedSprite;
        locationSelected = location;
    }
}