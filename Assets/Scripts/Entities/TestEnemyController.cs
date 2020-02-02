using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TestEnemyController : EnemyBase
{
    [SerializeField]
    private NavMeshAgent agent;

    protected override void FixedUpdate()
    {
        if (detectedPlayer /*&& (transform.position - player.position).magnitude > attackRange*/)
        {
            agent.destination = player.position;
            agent.speed = moveSpeed;
            agent.stoppingDistance = attackRange;
            //Move(-(transform.position - player.position).normalized);
        }
    }
}
