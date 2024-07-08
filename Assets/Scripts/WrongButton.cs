using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongButton : MonoBehaviour
{
    AudioManager audioManager;
    public GameObject PanelOpen;

    public void OpenPanelOnly()
    {
        if (PanelOpen != null)
        {
            PanelOpen.SetActive(true);          

        }
    }
}