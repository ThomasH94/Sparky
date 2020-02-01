using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputData
{
    public Vector2 directional;
    public bool jump;
    public int useAbility;
}

public class PlayerController : EntityController
{
    private Input input;
    public InputData inputData;

    [NonSerialized]
    public bool inputEnabled;

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
    }

    protected virtual void Move(Vector2 directionalInput)
    {
        if (Math.Abs(directionalInput.x) > .01f || Math.Abs(directionalInput.y) > .01f)
        {
            body.MovePosition(body.position + directionalInput.normalized * moveSpeed * Time.deltaTime);

            SetFacingDirection(directionalInput);
        }
        else
        {
            body.velocity = new Vector2(0, 0);
        }
    }

    protected virtual void DoAbility(int index)
    {
        Debug.Log("Use Ability: " + index);
    }
}
