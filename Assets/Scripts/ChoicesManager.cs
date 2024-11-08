using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoicesManager : MonoBehaviour
{
    public ChoicesDieTrigger playerHealth;  // Reference to the PlayerHealth script
    public int damageAmount = 30;      // Amount of damage for a wrong choice

    // Method to be called when a choice is made
    public void MakeChoice(bool isCorrect)
    {
        if (!isCorrect)
        {
            DealDamage();
        }
        else
        {
            Debug.Log("Correct choice!");
        }
    }

    // Method to apply damage
    private void DealDamage()
    {
        if (playerHealth != null)
        {
            playerHealth.QuizTakeDamage(damageAmount);
            Debug.Log("Wrong choice! Damage dealt: " + damageAmount);
        }

        else
        {
            Debug.LogError("PlayerHealth reference not set!");
        }
    }

    public void OnWrongChoiceButtonClicked()
    {
        // Simulate a wrong choice
        MakeChoice(false);
    }

    public void OnCorrectChoiceButtonClicked()
    {
        // Simulate a correct choice
        MakeChoice(true);
    }
}
