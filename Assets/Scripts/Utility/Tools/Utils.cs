using System;
using System.Collections;
using UnityEngine;

public static class Utils
{
    public static IEnumerator cooldownCoroutine(float duration_, Action onComplete_ = null)
    {
        return cooldownCoroutine(duration_, null, onComplete_);
    }

    public static IEnumerator cooldownCoroutine(float duration_, Action onUpdate_, Action onComplete_)
    {
        float remainingTime = duration_;

        while (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            onUpdate_?.Invoke();
            yield return null;
        }

        onComplete_?.Invoke();
    }
}