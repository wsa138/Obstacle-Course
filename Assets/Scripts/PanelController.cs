using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject myPanel; // Reference to your panel GameObject

    // Call this method when you want to hide the panel
    public void HidePanel()
    {
        myPanel.SetActive(false); // Deactivate the panel to hide it
    }

    // Call this method when you want to show the panel again
    public void ShowPanel()
    {
        myPanel.SetActive(true); // Activate the panel to show it
    }
}
