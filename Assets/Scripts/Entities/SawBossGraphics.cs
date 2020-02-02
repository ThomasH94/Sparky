using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawBossGraphics : MonoBehaviour
{
    [SerializeField]
    private SawBossController controller;
    [SerializeField]
    private Animator anim;

    private void Start()
    {
        //controller.onDamaged += i => anim.SetTrigger("hit");
        controller.onDied += () => anim.SetTrigger("die");
        controller.onUseAbility += OnUseAbility;
        controller.onToggleSpinning += ToggleSpinning;
    }

    private void ToggleSpinning(bool on)
    {
        if(on)
            anim.SetTrigger("spin");
        else
            anim.SetTrigger("stopSpin");
    }

    private void OnUseAbility(int number)
    {
        if (number == 1)
            anim.SetTrigger("attack");
        else if (number == 2)
            anim.SetTrigger("spin");
    }
}
