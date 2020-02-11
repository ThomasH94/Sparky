using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityAttack : AbilityBase
{
    [SerializeField]
    protected EntityController entityController;

    [SerializeField]
    protected EntityGraphics entityGraphics;

    [SerializeField]
    protected int damage;

    [SerializeField]
    protected float attackWindup;

    [SerializeField]
    protected LayerMask targetMask;

    [SerializeField]
    protected string abilityAnimation = "attack";

    [SerializeField]
    protected List<EntityController> targetsInRange = new List<EntityController>();

    protected IEnumerator _startDelayTimerRoutine;

    public override void DoUse()
    {
        base.DoUse();

        if (attackWindup <= 0)
        {
            dealDamage();
        }
        else
        {
            startAttackTimer(dealDamage);
        }

        PlayAnimation();
    }

    private void startAttackTimer(Action onComplete_)
    {
        if (_startDelayTimerRoutine != null)
            StopCoroutine(_startDelayTimerRoutine);

        _startDelayTimerRoutine = Utils.cooldownCoroutine(attackWindup, onComplete_);
        StartCoroutine(_startDelayTimerRoutine);
    }

    public virtual void dealDamage()
    {
        int attackDamage = entityController ?
                               (int)(damage * entityController.damageScale) :
                               damage;

        foreach (EntityController target in targetsInRange)
        {
            target.DoDamage(attackDamage);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (targetMask == (targetMask | (1 << other.gameObject.layer)))
        {
            EntityController entity = findEntityController(other);

            if (entity == null)
                return;

            targetsInRange.Add(entity);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        EntityController entity = findEntityController(other);

        if (entity == null)
            return;

        if (targetMask == (targetMask | (1 << other.gameObject.layer)))
            targetsInRange.Remove(entity);
    }

    private EntityController findEntityController(Component other)
    {
        EntityController entity = other.GetComponent<EntityController>();

        if (entity == null)
        {
            entity = other.GetComponentInParent<EntityController>();
        }

        return entity;
    }

    public virtual void PlayAnimation()
    {
        if (entityGraphics == null)
            return;

        entityGraphics.PlayAnimation(abilityAnimation);
    }
}
