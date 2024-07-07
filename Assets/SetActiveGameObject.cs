using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveGameObject : MonoBehaviour
{
    public GameObject activeGameObject;
    public GameObject disableGameObject;
    private void OnTriggerEnter(Collider collision)
    {        
        if (collision.gameObject.tag == "Player")
        {
            if (activeGameObject != null)
            {
                activeGameObject.SetActive(true);
                StartCoroutine(DisableObject());
            }
        }
    }

    IEnumerator DisableObject()
    {
        yield return new WaitForSeconds(0.5f);
        disableGameObject.SetActive(false);
    }
}
