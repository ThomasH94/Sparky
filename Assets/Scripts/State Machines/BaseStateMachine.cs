using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStateMachine : MonoBehaviour
{
    public List<ScriptableObjectState> allStates;
    public ScriptableObjectState currentState;
    public ScriptableObjectState previousState;

    // Change states to the new state if available
    public virtual void ChangeState(ScriptableObjectState stateToTransitionTo)
    {
        bool canTransition = false;
        for (int i = 0; i < allStates.Count; i++)
        {
            if(allStates[i].name == stateToTransitionTo.name)
            {
                canTransition = true;
                break;
            }
        }

        if(!canTransition)
        {
            return;
        }
        
        previousState = currentState;
        currentState = stateToTransitionTo;

    }

    public ScriptableObject GetCurrentState()
    {
        return currentState;
    }

    // Compare states for sake of ease
    public bool CompareState(string stateName)
    {
        if(currentState.name == stateName)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
