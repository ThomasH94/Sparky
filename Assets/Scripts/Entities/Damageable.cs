using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public OnHealthUpdated HealthUpdatedEvent;

    public delegate void OnHealthUpdated(float amount);

    private void Start()
    {
        health = maxHealth;
    }

    public virtual int DoDamage(int amount)
    {
        if (health - amount < 0)
            amount = health;

        health -= amount;

        HealthUpdatedEvent.Invoke((float)health / maxHealth);

        if (health <= 0)
            DoDie();

        return amount;
    }

    public virtual void DoDie()
    {

    }

    public virtual int DoHeal(int amount)
    {
        if (health + amount > maxHealth)
            amount = maxHealth - health;

        health += amount;

        HealthUpdatedEvent.Invoke(health / maxHealth);

        return amount;
    }
}
