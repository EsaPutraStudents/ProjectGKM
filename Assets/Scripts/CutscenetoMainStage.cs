using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutscenetoMainStage : MonoBehaviour
{
    private void OnEnable()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Map1", LoadSceneMode.Single);
    }
}
