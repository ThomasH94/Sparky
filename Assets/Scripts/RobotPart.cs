using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PartType
{
    Arm,
    Leg,
    Heart
}

/// <summary>
/// This script will be the basis of the prefab for collecting Robot Parts
/// </summary>
public class RobotPart : MonoBehaviour
{
    public PartType partType;

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(collider2D.gameObject.GetComponent<PlayerController>())
        {
            Destroy(gameObject);
        }
    }
}