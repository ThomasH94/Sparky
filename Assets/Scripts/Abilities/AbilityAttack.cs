using System.Collections.Generic;
using UnityEngine;

public class AbilityAttack : AbilityBase
{
    [SerializeField]
    private EntityController entityController;

    [SerializeField]
    private EntityGraphics entityGraphics;

    [SerializeField]
    private int damage;

    [SerializeField]
    private LayerMask targetMask;

    [SerializeField]
    private string abilityAnimation = "attack";

    [SerializeField]
    private List<EntityController> targetsInRange = new List<EntityController>();

    public override void DoUse()
    {
        base.DoUse();

        int attackDamage = entityController ? 
                               (int)(damage * entityController.damageScale) : 
                               damage;

        foreach (EntityController target in targetsInRange)
        {
            target.DoDamage(attackDamage);
        }

        PlayAnimation();
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

    public void PlayAnimation()
    {
        if (entityGraphics == null)
            return;

        entityGraphics.PlayAnimation(abilityAnimation);
    }
}
