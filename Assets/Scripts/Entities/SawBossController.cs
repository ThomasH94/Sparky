using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawBossController : EnemyBase
{
    public event Action<bool> onToggleSpinning;
    public GameObject TriggerArea;
    public Renderer bossRenderer;

    protected override void Start()
    {
        base.Start();
        enemyRenderer = bossRenderer;
    }

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

    public override int DoDamage(int amount)
    {
        base.DoDamage(amount);
        if(health <= 50 && !isDead)
        {
            DoDie();
        }
        return amount;
    }

    public override void DoDie()
    {
        base.DoDie();
        TriggerArea.GetComponent<TriggerBossBattle>().OpenDoor();
    }
}
