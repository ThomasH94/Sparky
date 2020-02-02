using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawBossController : EnemyBase
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
