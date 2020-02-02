using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Swipe : AbilityBase
{
    [SerializeField]
    private int damage;
    [SerializeField]
    private LayerMask targetMask;

    public List<EntityController> targetsInRange = new List<EntityController>();

    public override void DoUse()
    {
        base.DoUse();

        foreach (EntityController target in targetsInRange)
        {
            target.DoDamage(damage);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (targetMask == (targetMask | (1 << other.gameObject.layer)))
            targetsInRange.Add(other.GetComponent<EntityController>());
    }

    private void OnTriggerExit(Collider other)
    {
        if (targetMask == (targetMask | (1 << other.gameObject.layer)))
            targetsInRange.Remove(other.GetComponent<EntityController>());
    }
}
