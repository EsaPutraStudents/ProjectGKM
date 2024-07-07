using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound : MonoBehaviour
{
    public AudioSource jumpSound;
    public bool notJumping = true;
    public float jumpCooldown = 0.75f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (notJumping)
            {
                jumpSound.enabled = true;
                notJumping = false;
                StartCoroutine(JumpCooldown());
            }
            

        }
        else
        {
            jumpSound.enabled = false;

        }
    }
    IEnumerator JumpCooldown()
    {
        yield return new WaitForSeconds(jumpCooldown);
        notJumping = true;
    }
}
