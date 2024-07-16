using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoicesDieTrigger : MonoBehaviour
{
    [SerializeField] private int health = 90;
    public Slider healthBar;    
    public GameObject panel;

    void Update()
    {
        healthBar.value = health;
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
        {
            Die();
        }        
    }

    private void Die()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }
}
