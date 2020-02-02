using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbilityBase : MonoBehaviour
{
    public float cooldown;

    public float cooldownRemaining;

    private IEnumerator cooldownTimerRoutine;

    public virtual void DoUse(PlayerController player_)
    {
        if (cooldownRemaining > 0)
            return;

        cooldownTimerRoutine = CooldownTimer(cooldown);
        StartCoroutine(cooldownTimerRoutine);
    }

    private IEnumerator CooldownTimer(float duration)
    {
        cooldownRemaining = cooldown;

        while (cooldownRemaining > 0)
        {
            cooldownRemaining -= Time.deltaTime;
            yield return null;
        }

        cooldownRemaining = 0;
    }
}
