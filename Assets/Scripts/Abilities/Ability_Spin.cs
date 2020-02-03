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

    public bool isSpinning;

    public override void DoUse()
    {
        base.DoUse();

        controller.moveSpeed = 10f;
        controller.agent.SetDestination(controller.player.position);

        foreach (var o in sawColliders)
            o.SetActive(true);

        isSpinning = true;
        controller.ToggleSpinning(true);
    }

    private void FixedUpdate()
    {
        if (controller.isAtDestination && isSpinning)
        {
            isSpinning = false;
            //Debug.Log("Reached it");
            StartCoroutine(DelayEndSpin());
        }
    }

    private IEnumerator DelayEndSpin()
    {
        yield return new WaitForSeconds(1.5f);

        //Debug.Log("stop");
        controller.moveSpeed = 0f;
        controller.agent.SetDestination(transform.position);
        
        controller.ToggleSpinning(false);

        foreach (var o in sawColliders)
            o.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (targetMask == (targetMask | (1 << other.gameObject.layer)))
            other.GetComponent<EntityController>().DoDamage(damage);
    }


}
