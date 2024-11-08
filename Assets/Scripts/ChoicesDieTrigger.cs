using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoicesDieTrigger : MonoBehaviour
{
    [SerializeField] private int health = 90;
    public Slider healthBar;    
    public GameObject panel;
    private bool isInvincible = false;
    private float timeSinceHit = 0;
    public float invincibleTime = 1f;

    void Update()
    {
        healthBar.value = health;
        if (isInvincible)
        {
            if(timeSinceHit > invincibleTime)
            {
                isInvincible = false;
                timeSinceHit = 0;
            }
            else
            {
                timeSinceHit += Time.deltaTime;
            }
        }
    }

    public void QuizTakeDamage(int damageAmount)
    {               
        health -= damageAmount;           
        
        if (health <= 0)
        {
            Die();
        }

    }


    public void TakeDamage(int damageAmount)
    {
        if (!isInvincible) { 
            health -= damageAmount;
            isInvincible = true;
        }
        if (health <= 0)
        {
            Die();
        }
        
    }

    private void Die()
    {
        UnlockMouse();
        panel.SetActive(true);
        Time.timeScale = 0;
    }

    void UnlockMouse()
    {
        UnityEngine.Cursor.lockState = CursorLockMode.None;
        UnityEngine.Cursor.visible = true;
    }
}
