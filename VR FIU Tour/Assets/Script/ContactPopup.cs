using UnityEngine;

public class ContactPopup : MonoBehaviour
{
    public GameObject popupPanel; // Assign your UI popup panel in the Inspector

    // Toggle the popup on and off
    public void TogglePopup()
    {
        if (popupPanel != null)
        {
            popupPanel.SetActive(!popupPanel.activeSelf);
        }
        else
        {
            Debug.LogWarning("Popup Panel is not assigned!");
        }
    }
}


