using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RobotPartType
{
    Arm,
    Leg,
    Heart
}

/// <summary>
/// This script will be the basis of the prefab for collecting Robot Parts
/// </summary>
public class RobotPart : InteractableObject
{
    public RobotPartType partType;

    public override void InteractAction(PlayerController player)
    {
        player.PlayerInventory.addItem(partType.ToString());

        //todo: fancy celebration or somethin
        Debug.Log($"YOU GOT THE {partType}!!");

        Destroy(gameObject);
    }
}