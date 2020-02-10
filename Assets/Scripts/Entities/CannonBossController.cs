using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBossController : EnemyBase
{
    public GameObject TriggerArea;
    public Renderer bossRenderer;
    public GameObject projectileToSpawn;
    public Transform spawnPosition;
    public CannonBossGraphics bossGraphics;
    bool canSelectAction = true;

    protected override void Start()
    {
        base.Start();
        enemyRenderer = bossRenderer;
    }

    private void SelectAction()
    {
        int actionResult = UnityEngine.Random.Range(0,5);

        switch(actionResult)
        {
            case 0: //Move
                AvoidPlayer();
                break;
            case 1: // Idle
                bossGraphics.TriggerAnimation("Idle");
                break;
            case 2:
                AvoidPlayer();
                break;
            default: //Attack
                DoAttack();
                break;
        }

        StartCoroutine(CoolDownRoutine());
    }

    private void AvoidPlayer()
    {
        bossGraphics.TriggerAnimation("Moving");
        Vector3 newDestination = new Vector3(player.transform.position.x + 5f, player.transform.position.y, player.transform.position.z + 5f);
        agent.SetDestination(newDestination);
        agent.speed = -moveSpeed;
    }

    private void DoAttack()
    {
        bossGraphics.TriggerAnimation("Attack");
        StartCoroutine(SpawnRoutine());
        agent.speed = moveSpeed;
    }

    private IEnumerator SpawnRoutine()
    {
        yield return new WaitForSeconds(0.3f);
        Instantiate(projectileToSpawn, spawnPosition.position, Quaternion.identity);
    }

    protected override void FixedUpdate()
    {
        if (detectedPlayer)
        {
            if(canSelectAction)
            SelectAction();

            //if(isInAttackRange)
                //DoAbility(1);
        }

        base.FixedUpdate();
    }

    private IEnumerator CoolDownRoutine()
    {
        canSelectAction = false;
        float timer = UnityEngine.Random.Range(2, 4);
        yield return new WaitForSeconds(timer);
        canSelectAction = true;
        //SelectAction();
    }

    public override int DoDamage(int amount)
    {
        base.DoDamage(amount);
        if(health <= 30  && !isDead)
        {
            DoDie();
        }
        return amount;
    }

    public override void DoDie()
    {
        base.DoDie();
        bossGraphics.TriggerAnimation("Death");
        TriggerArea.GetComponent<TriggerBossBattle>().OpenDoor();
    }
}
