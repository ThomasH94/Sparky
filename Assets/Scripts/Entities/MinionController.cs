using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MinionController : EnemyBase
{
    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        if (detectedPlayer && isInAttackRange)
        {
            DoAbility(1);
        }
    }

}
