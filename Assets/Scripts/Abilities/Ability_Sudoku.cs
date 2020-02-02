using UnityEngine;

public class Ability_Sudoku : AbilityBase
{
    int damage = 10;
    [SerializeField]
    private Damageable target; 

    public override void DoUse()
    {
        if (cooldownRemaining > 0)
            return;

        target.DoDamage(damage);

        Debug.Log("DISHONOR UPON MY FAMILY");
    }
}
