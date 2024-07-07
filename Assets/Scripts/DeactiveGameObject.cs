using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactiveGameObject : MonoBehaviour
{
    public GameObject disableGameObject;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            disableGameObject.SetActive(false);
        }

    }
}
