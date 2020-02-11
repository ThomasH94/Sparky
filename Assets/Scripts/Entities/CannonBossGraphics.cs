using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBossGraphics : MonoBehaviour
{
    public Animator cannonBossAnimator;

    public void TriggerAnimation(string animationToTrigger)
    {
        cannonBossAnimator.SetTrigger(animationToTrigger);
        Debug.Log("Cannon Boss Animation Triggered: Trigger was " + animationToTrigger);
    }
}
