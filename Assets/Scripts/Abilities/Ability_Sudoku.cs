using UnityEngine;

public class Ability_Sudoku : AbilityBase
{
    int damage = 10;

    public override void DoUse(PlayerController player_)
    {
        if (cooldownRemaining > 0)
            return;

        player_.DoDamage(damage);

        Debug.Log("DISHONOR UPON MY FAMILY");
    }
}
