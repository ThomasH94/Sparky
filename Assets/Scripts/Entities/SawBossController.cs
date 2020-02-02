using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawBossController : EnemyBase
{
    public event Action<bool> onToggleSpinning;

    public void ToggleSpinning(bool on)
    {
        onToggleSpinning?.Invoke(on);
    }

    protected override void FixedUpdate()
    {
        if (detectedPlayer)
        {
            DoAbility(2);

            if(isInAttackRange)
                DoAbility(1);
        }

        base.FixedUpdate();
    }
}
