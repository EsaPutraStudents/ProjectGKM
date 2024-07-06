using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveNextStage : MonoBehaviour
{
    public string sceneName;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
            Time.timeScale = 1;
            
        }
    }

}
