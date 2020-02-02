using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawBossGraphics : MonoBehaviour
{
    [SerializeField]
    private MinionController controller;
    [SerializeField]
    private Animator anim;

    private void Start()
    {
        //controller.onDamaged += i => anim.SetTrigger("hit");
        controller.onDied += () => anim.SetTrigger("die");
        controller.onUseAbility += OnUseAbility;
    }

    private void OnUseAbility(int number)
    {
        if (number == 1)
            anim.SetTrigger("attack");
        else if (number == 2)
            anim.SetTrigger("spin");
    }
}
