using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionScript : MonoBehaviour
{

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
            Time.timeScale = 1;

        }
    }
}
