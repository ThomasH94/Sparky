using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public virtual int DoDamage(int amount)
    {
        if (health - amount < 0)
            amount = health;

        health -= amount;

        if (health <= 0)
            DoDie();

        return amount;
    }

    public virtual void DoDie()
    {

    }
}
