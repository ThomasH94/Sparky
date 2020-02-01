using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    public EnemyStateMachine enemyStateMachine;
    public ScriptableObjectState chaseState;

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(collider2D.GetComponent<PlayerController>())
        {
            if(!enemyStateMachine.CompareState("Chasing"))
            {
                enemyStateMachine.ChangeState(chaseState);
            }
        }
    }
}
