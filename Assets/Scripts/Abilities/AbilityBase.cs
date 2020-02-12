using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbilityBase : MonoBehaviour
{
    public float cooldown;

    public float cooldownRemaining;

    private IEnumerator _cooldownTimerRoutine;

    public virtual void DoUse()
    {
        if (_cooldownTimerRoutine != null)
            StopCoroutine(_cooldownTimerRoutine);

        _cooldownTimerRoutine = CooldownTimer(cooldown);
        StartCoroutine(_cooldownTimerRoutine);
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
