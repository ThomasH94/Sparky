using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Spin : AbilityBase
{
    [SerializeField]
    private int damage;
    [SerializeField]
    private LayerMask targetMask;

    public override void DoUse()
    {
        base.DoUse();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (targetMask == (targetMask | (1 << other.gameObject.layer)))
            other.GetComponent<EntityController>().DoDamage(damage);
    }
}
