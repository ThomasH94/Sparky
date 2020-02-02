using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGraphics : MonoBehaviour
{
    [SerializeField]
    private PlayerController controller;
    [SerializeField]
    private Animator anim;

    private void Start()
    {
        controller.onUseAbility += OnUseAbility;
        controller.onDied += () => anim.SetTrigger("die");
    }

    private void Update()
    {
        anim.SetBool("isWalking", controller.input.playerControls.directional.ReadValue<Vector2>() != Vector2.zero);
    }

    private void OnUseAbility(int index)
    {
        if (index == 1)
            anim.SetTrigger("swipeAttack");
    }

    //protected override void UpdateFacingDirection(FacingDirection newDir)
    //{

    //}
}
