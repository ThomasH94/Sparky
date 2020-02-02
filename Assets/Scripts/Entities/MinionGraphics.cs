using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionGraphics : MonoBehaviour
{
    [SerializeField]
    private MinionController controller;
    [SerializeField]
    private Animator anim;

    private void Start()
    {
        controller.onDamaged += i => anim.SetTrigger("hit");
        controller.onDied += () => anim.SetTrigger("die");
        controller.onUseAbility += i => anim.SetTrigger("attack");
    }

    private void Update()
    {
        anim.SetBool("isWalking", !controller.isAtDestination);
    }


}
