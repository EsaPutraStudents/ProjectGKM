using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseTutorial : MonoBehaviour
{
    public GameObject optionsMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (optionsMenu != null)
            {
                bool isActive = optionsMenu.activeSelf;

                optionsMenu.SetActive(!isActive);
            }
        }


    }
}
