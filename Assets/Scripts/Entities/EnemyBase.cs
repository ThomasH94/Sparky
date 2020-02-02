﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyBase : EntityController
{
    public NavMeshAgent agent;
    [SerializeField]
    protected LayerMask environmentMask;
    [SerializeField]
    protected float attackRange = 2f;

    public bool isInAttackRange;
    public bool isAtDestination;
    public bool detectedPlayer;
    public Transform player;

    protected IEnumerator losePlayerRoutine;

    protected override void Start()
    {
        base.Start();
        agent.destination = transform.position;
    }

    protected virtual void FixedUpdate()
    {
        if (detectedPlayer)
        {
            
            agent.speed = moveSpeed;
            agent.stoppingDistance = attackRange;

            transform.LookAt(player.position);

            isInAttackRange = (transform.position - player.position).magnitude <= attackRange + 1f;
        }
        
        isAtDestination = isInAttackRange || (agent.destination - transform.position).magnitude < agent.stoppingDistance + .1f;
    }

    public virtual void OnTriggerStay(Collider collider)
    {
        if (LayerMask.LayerToName(collider.gameObject.layer) == "Player")
        {
            if (Physics.Linecast(transform.position, collider.transform.position, environmentMask))
            {
                Debug.DrawLine(transform.position, collider.transform.position, Color.red);
                losePlayerRoutine = LosePlayer();
                StartCoroutine(losePlayerRoutine);
            }
            else
            {
                Debug.DrawLine(transform.position, collider.transform.position, Color.cyan);
                DetectPlayer(collider.transform);

                if (losePlayerRoutine != null)
                    StopCoroutine(losePlayerRoutine);
            }
        }
    }

    protected virtual void DetectPlayer(Transform player)
    {
        if (isDead) return;

        detectedPlayer = true;
        this.player = player;

        player.GetComponent<PlayerController>().onDied += OnPlayerDied;
    }

    protected virtual IEnumerator LosePlayer()
    {
        yield return new WaitForSeconds(5f);
        detectedPlayer = false;
        player = null;
    }

    public override void DoDie()
    {
        base.DoDie();
        detectedPlayer = false;
        player = null;
        agent.destination = transform.position;
    }

    protected virtual void OnPlayerDied()
    {
        detectedPlayer = false;
        player = null;
        agent.destination = transform.position;
    }
}
