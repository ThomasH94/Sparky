using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Swipe : AbilityBase
{
    public override void DoUse()
    {
        if (cooldownRemaining > 0)
            return;

        base.DoUse();

        //if()
    }
}
