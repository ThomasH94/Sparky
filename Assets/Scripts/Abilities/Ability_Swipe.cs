using UnityEngine;

public class Ability_Swipe : AbilityAttack
{
    [SerializeField]
    private string secondAbilityAnimation = "attack";

    private bool rightArm = true;

    public override void PlayAnimation()
    {
        if (entityGraphics == null)
            return;

        string attack = rightArm ? abilityAnimation : secondAbilityAnimation;
        rightArm = !rightArm;

        entityGraphics.PlayAnimation(attack);
    }
}
