using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveStage : MonoBehaviour
{  
    public int stageNumber;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            SceneManager.LoadScene(stageNumber);
            Time.timeScale = 1;

        }
    }

}
