using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Swipe : AbilityBase
{
    [SerializeField]
    private int damage;
    [SerializeField]
    private LayerMask enemyMask;

    public List<EnemyBase> enemiesInRange = new List<EnemyBase>();

    public override void DoUse(PlayerController player_)
    {
        base.DoUse(player_);

        foreach (EnemyBase enemy in enemiesInRange)
        {
            enemy.DoDamage(damage);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
            enemiesInRange.Add(other.GetComponent<EnemyBase>());
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == enemyMask)
            enemiesInRange.Remove(other.GetComponent<EnemyBase>());
    }
}
