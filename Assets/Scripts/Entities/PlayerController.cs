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
    [SerializeField]
    private CameraController cameraPrefab;

    [NonSerialized]
    public bool inputEnabled;

    [SerializeField]
    private PlayerInventory _playerInventory = new PlayerInventory();
    public PlayerInventory PlayerInventory {
        get => _playerInventory;
    }

    public Action<PlayerController> CurrentInteractAction;

    private Input input;
    private InputData inputData;

    protected override void Start()
    {
        base.Start();
        InitializeInput();

        Instantiate(cameraPrefab).Initialize(transform);
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
        base.FixedUpdate();

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

        input.playerControls.Interact.performed += DoInteract;
    }

    private void DoInteract(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        CurrentInteractAction?.Invoke(this);
        CurrentInteractAction = null;
    }

    //protected override void Move(Vector2 directionalInput) { }

    protected virtual void DoAbility(int index)
    {
        //Debug.Log("Use Ability: " + index);
    }
}
