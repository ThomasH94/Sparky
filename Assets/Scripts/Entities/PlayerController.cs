using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//[Serializable]
//public class InputData
//{
//    public Vector2 directional;
//    public int useAbility;
//    public bool interact;
//}

public class PlayerController : EntityController
{
    public event Action<int> onUseAbility;
    public Action CurrentInteractAction;

    [SerializeField]
    private CameraController cameraPrefab;
    [SerializeField]
    private AbilityBase[] abilities;

    [NonSerialized]
    public bool inputEnabled;

    public Input input;
    //public InputData inputData;

    protected override void Start()
    {
        base.Start();
        InitializeInput();

        Instantiate(cameraPrefab).Initialize(transform);
    }

    private void InitializeInput()
    {
        input = new Input();
        //inputData = new InputData();

        input.playerControls.use1.performed += context => DoAbility(1);
        input.playerControls.use2.performed += context => DoAbility(2);
        input.playerControls.use3.performed += context => DoAbility(3);
        input.playerControls.use4.performed += context => DoAbility(4);
        input.playerControls.use5.performed += context => DoAbility(5);
        input.playerControls.use6.performed += context => DoAbility(6);

        input.Enable();
        inputEnabled = true;
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        Move(input.playerControls.directional.ReadValue<Vector2>());

        //if (inputData.useAbility > 0)
        //    DoAbility(inputData.useAbility);

        //if (inputData.interact)
        //{
        //    DoInteract();
        //}
    }

    //protected virtual void GetInputData()
    //{
    //    inputData.directional = input.playerControls.directional.ReadValue<Vector2>();

    //    if (input.playerControls.use1.ReadValue<float>() > 0)
    //        inputData.useAbility = 1;
    //    else if (input.playerControls.use2.ReadValue<float>() > 0)
    //        inputData.useAbility = 2;
    //    else if (input.playerControls.use3.ReadValue<float>() > 0)
    //        inputData.useAbility = 3;
    //    else if (input.playerControls.use4.ReadValue<float>() > 0)
    //        inputData.useAbility = 4;
    //    else if (input.playerControls.use5.ReadValue<float>() > 0)
    //        inputData.useAbility = 5;
    //    else if (input.playerControls.use6.ReadValue<float>() > 0)
    //        inputData.useAbility = 6;
    //    else
    //        inputData.useAbility = 0;

    //    if (input.playerControls.Interact.ReadValue<float>() > 0)
    //    {
    //        inputData.interact = true;
    //    }
    //    else
    //    {
    //        inputData.interact = false;
    //    }
    //}

    //protected override void Move(Vector2 directionalInput) { }

    protected virtual void DoAbility(int index)
    {
        if(abilities.Length >= index)
            abilities[index - 1]?.DoUse();

        onUseAbility?.Invoke(index);
        //Debug.Log("Use Ability: " + index);
    }

    private void DoInteract()
    {
        CurrentInteractAction?.Invoke();
    }
}
