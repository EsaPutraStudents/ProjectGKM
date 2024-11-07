using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionDetection : MonoBehaviour
{
    public int damageAmount = 20;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //transform.parent = other.transform;
            other.GetComponent<ChoicesDieTrigger>().TakeDamage(damageAmount);
        }
    }
}
