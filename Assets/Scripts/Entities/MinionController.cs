using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MinionController : EnemyBase
{
    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        if (detectedPlayer)
        {
            agent.destination = player.position;

            if(isInAttackRange)
                DoAbility(1);
        }
    }

}
