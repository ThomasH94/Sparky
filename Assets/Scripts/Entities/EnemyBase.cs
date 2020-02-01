using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBase : EntityController
{
    [SerializeField]
    private LayerMask environmentMask;

    public virtual void OnTriggerStay2D(Collider2D collider)
    {
        if (LayerMask.LayerToName(collider.gameObject.layer) == "Player")
        {
            if (Physics2D.Linecast(transform.position, collider.transform.position, environmentMask).transform == null)
                DetectPlayer();
        }
    }

    protected virtual void DetectPlayer() { }
}
