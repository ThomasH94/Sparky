using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script will act as the basis for any object that wants a health component
/// </summary>
public class BaseHealth : MonoBehaviour
{
    private float currentHealth;
    public float CurrentHealth
    {
        get
        {
            return currentHealth;
        }
        set
        {
            currentHealth = value;
            if(currentHealth < MIN_HEALTH)
            {
                currentHealth = 0;
            }
            else if(currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }

            Debug.Log("Current health: " + CurrentHealth);
        }
    }
    public float maxHealth;
    private const float MIN_HEALTH = 0f;
    private const float DEFAULT_HEALTH = 10f;

    private void Start()
    {
        CurrentHealth = DEFAULT_HEALTH;
    }

    public virtual void SubtractHealth(float healthToSubtract)
    {
        CurrentHealth -= healthToSubtract;
    }

    public virtual void AddHealth(float healthToAdd)
    {
        CurrentHealth += healthToAdd;
    }
}
