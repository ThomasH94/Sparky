using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBase : EntityController
{
    [SerializeField]
    protected LayerMask environmentMask;

    public bool detectedPlayer;
    protected Transform player;

    protected IEnumerator losePlayerRoutine;

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
        detectedPlayer = true;
        this.player = player;
    }

    protected virtual IEnumerator LosePlayer()
    {
        yield return new WaitForSeconds(1f);
        detectedPlayer = false;
        player = null;
    }
}
