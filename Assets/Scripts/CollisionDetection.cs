using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public int damageAmount = 20;    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            //transform.parent = other.transform;
            other.GetComponent<Enemy>().TakeDamage(damageAmount);
        }
    }
}
