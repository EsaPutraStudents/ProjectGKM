using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpenClose : MonoBehaviour
{
    public GameObject Panel;

    public void OpenClosePanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }
    }

    public void TimeActive()
    {
        Time.timeScale = 1;
        LockMouse();
    }

    public void LockMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
