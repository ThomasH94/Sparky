using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public bool isDead;

    public event Action onDied;

    public OnHealthUpdated HealthUpdatedEvent;

    public delegate void OnHealthUpdated(float amount);

    protected virtual void Start()
    {
        health = maxHealth;
    }

    public virtual int DoDamage(int amount)
    {
        if (health - amount < 0)
            amount = health;

        health -= amount;

        HealthUpdatedEvent?.Invoke((float)health / maxHealth);
        Debug.Log(gameObject.name + " took damage: " + amount);

        if (health <= 0)
            DoDie();

        return amount;
    }

    public virtual void DoDie()
    {
        Debug.Log(gameObject.name + " died");
        isDead = true;
        onDied?.Invoke();
    }

    public virtual int DoHeal(int amount)
    {
        if (health + amount > maxHealth)
            amount = maxHealth - health;

        health += amount;

        HealthUpdatedEvent?.Invoke(health / maxHealth);

        return amount;
    }
}
