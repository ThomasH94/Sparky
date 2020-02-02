using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyBase : EntityController
{
    [SerializeField]
    private NavMeshAgent agent;
    [SerializeField]
    protected LayerMask environmentMask;

    public bool detectedPlayer;
    protected Transform player;

    protected IEnumerator losePlayerRoutine;

    private void FixedUpdate()
    {
        if (detectedPlayer)
        {
            agent.destination = player.position;
            agent.speed = moveSpeed;
            agent.stoppingDistance = attackRange;
        }
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
}
