using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class OpenCanvasSoal : MonoBehaviour
{
    public GameObject canvasSoal;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (canvasSoal != null)
            {
                canvasSoal.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
