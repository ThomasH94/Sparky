using System.Collections;
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

    [SerializeField]
    protected GameObject dropPrefab;

    public bool isInAttackRange;
    public bool isAtDestination;
    public bool detectedPlayer;
    public Transform player;

    protected IEnumerator losePlayerRoutine;

    #region Flashing
    [SerializeField] protected Renderer enemyRenderer;
    bool isFlashing = false;
    #endregion

    protected override void Start()
    {
        base.Start();
        agent.destination = transform.position;
        enemyRenderer = GetComponentInChildren<Renderer>();
        if(enemyRenderer == null)
        {
            Debug.Log("Enemy material not found on " + gameObject.name);
        }
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

    public override int DoDamage(int amount)
    {
        base.DoDamage(amount);
        if(!isDead)
        StartCoroutine(FlashRoutine());

        return amount;
    }

    protected virtual IEnumerator FlashRoutine()
    {
        Color flashColor = Color.red;
        Color baseColor = enemyRenderer.material.color;

        if(!isFlashing)
        {
            isFlashing = true;
            enemyRenderer.material.color = flashColor;
            yield return new WaitForSeconds(0.1f);
            enemyRenderer.material.color = baseColor;
            yield return new WaitForSeconds(0.1f);
            enemyRenderer.material.color = flashColor;
            yield return new WaitForSeconds(0.1f);
            enemyRenderer.material.color = baseColor;
             yield return new WaitForSeconds(0.1f);
            enemyRenderer.material.color = flashColor;
            yield return new WaitForSeconds(0.1f);
            enemyRenderer.material.color = baseColor;
            isFlashing = false;
        }

    }

    public override void DoDie()
    {
        base.DoDie();
        detectedPlayer = false;
        player = null;
        agent.destination = transform.position;
        Instantiate(dropPrefab, transform.position, Quaternion.identity);
        body = null;
    }

    protected virtual void OnPlayerDied()
    {
        detectedPlayer = false;
        player = null;
        agent.destination = transform.position;
    }
}
