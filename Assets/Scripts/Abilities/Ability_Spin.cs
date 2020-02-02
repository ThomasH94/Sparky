using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Spin : AbilityBase
{
    [SerializeField]
    private SawBossController controller;
    [SerializeField]
    private int damage;
    [SerializeField]
    private LayerMask targetMask;

    [SerializeField]
    private GameObject[] sawColliders;

    private bool isSpinning;

    public override void DoUse()
    {
        base.DoUse();
        Debug.Log("Use spoin");
        controller.moveSpeed = 10f;
        controller.agent.SetDestination(controller.player.position);

        foreach (var o in sawColliders)
            o.SetActive(true);

        isSpinning = true;
        controller.ToggleSpinning(true);
    }

    private void FixedUpdate()
    {
        Debug.Log(controller.agent.destination);
        if (controller.isAtDestination && isSpinning)
        {
            controller.moveSpeed = 0f;
            controller.agent.SetDestination(transform.position);
            isSpinning = false;
            controller.ToggleSpinning(false);

            foreach (var o in sawColliders)
                o.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (targetMask == (targetMask | (1 << other.gameObject.layer)))
            other.GetComponent<EntityController>().DoDamage(damage);
    }


}
