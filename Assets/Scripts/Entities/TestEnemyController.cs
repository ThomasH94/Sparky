using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemyController : EnemyBase
{


    protected override void FixedUpdate()
    {
        if (detectedPlayer && (transform.position - player.position).magnitude > attackRange)
        {
            Move(-(transform.position - player.position).normalized);
        }
    }
}
