using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject optionsMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (optionsMenu != null)
            {
                bool isActive = optionsMenu.activeSelf;

                optionsMenu.SetActive(!isActive);
            }
        }


    }
    //if (Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        if (Time.timeScale == 0)
    //        {
    //            Time.timeScale = 1;
    //           gameObject.SetActive(false);
    //       }
    //        else
    //{
    //   Time.timeScale = 0;
    //    gameObject.SetActive(true);
    //}
    //        }

}
