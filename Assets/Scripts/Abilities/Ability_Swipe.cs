using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Swipe : AbilityBase
{
    public override void DoUse(PlayerController player_)
    {
        if (cooldownRemaining > 0)
            return;

        base.DoUse(player_);

        //if()
    }
}
