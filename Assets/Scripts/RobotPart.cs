using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script will be the basis of the prefab for collecting Robot Parts
/// </summary>
public class RobotPart : InteractableObject
{
    public RobotPartType partType;

    public override void InteractAction(PlayerController player)
    {
        base.InteractAction(player);

        player.PlayerInventory.addItem(partType);

        DialogueManager.Instance.ShowDialogue($"YOU GOT THE <color=#0ff>{partType.ToString()}</color>!! Return it to the robot buddy at the base.", 4);

        Destroy(gameObject);
    }
}