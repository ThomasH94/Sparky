using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class InputData
{
    public Vector2 directional;
    public bool jump;
    public int useAbility;
    public bool interact;
}

public class PlayerController : EntityController
{
    private Input input;
    public InputData inputData;

    [NonSerialized]
    public bool inputEnabled;

    public Action CurrentInteractAction;

    public void Start()
    {
        InitializeInput();
    }

    private void InitializeInput()
    {
        input = new Input();
        inputData = new InputData();

        input.Enable();
        inputEnabled = true;
    }

    protected override void FixedUpdate()
    {
        GetInputData();

        Move(inputData.directional);

        if (inputData.useAbility > 0)
            DoAbility(inputData.useAbility);

        if (inputData.interact)
        {
            DoInteract();
        }
    }

    protected virtual void GetInputData()
    {
        inputData.directional = input.playerControls.directional.ReadValue<Vector2>();
        inputData.jump = input.playerControls.jump.ReadValue<float>() > 0;

        if (input.playerControls.use1.ReadValue<float>() > 0)
            inputData.useAbility = 1;
        else if (input.playerControls.use2.ReadValue<float>() > 0)
            inputData.useAbility = 2;
        else if (input.playerControls.use3.ReadValue<float>() > 0)
            inputData.useAbility = 3;
        else if (input.playerControls.use4.ReadValue<float>() > 0)
            inputData.useAbility = 4;
        else if (input.playerControls.use5.ReadValue<float>() > 0)
            inputData.useAbility = 5;
        else if (input.playerControls.use6.ReadValue<float>() > 0)
            inputData.useAbility = 6;
        else
            inputData.useAbility = 0;

        if (input.playerControls.Interact.ReadValue<float>() > 0)
        {
            inputData.interact = true;
        }
        else
        {
            inputData.interact = false;
        }


    }

    //protected override void Move(Vector2 directionalInput) { }

    protected virtual void DoAbility(int index)
    {
        //Debug.Log("Use Ability: " + index);
    }

    private void DoInteract()
    {
        CurrentInteractAction?.Invoke();
    }
}
