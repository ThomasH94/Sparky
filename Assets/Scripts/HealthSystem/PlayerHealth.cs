using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script inherits from BaseHealth so they play can define how to take damage and wrap things in coroutines
/// for presentation
/// </summary>
public class PlayerHealth : BaseHealth
{
    [SerializeField]
    private FillStatusBar healthBar = null; // Have to do this for serializable fields now..

    public override void SubtractHealth(float healthToSubtract)
    {
        base.SubtractHealth(healthToSubtract);
        healthBar.UpdateHealthSlider();
    }

    public override void AddHealth(float healthToAdd)
    {
        base.AddHealth(healthToAdd);
        healthBar.UpdateHealthSlider();
    }

}
