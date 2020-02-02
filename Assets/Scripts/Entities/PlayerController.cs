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
    public Action<PlayerController> CurrentInteractAction;

    [SerializeField]
    private CameraController cameraPrefab;
    [SerializeField]
    private AbilityBase[] abilities;

    [NonSerialized]
    public bool inputEnabled;

    [SerializeField]
    private PlayerInventory _playerInventory = new PlayerInventory();
    public PlayerInventory PlayerInventory {
        get => _playerInventory;
    }

    public Input input;
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

        input.playerControls.Interact.performed += DoInteract;

        input.Enable();
        inputEnabled = true;
    }

    private void DoInteract(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        CurrentInteractAction?.Invoke(this);
        CurrentInteractAction = null;
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        Move(input.playerControls.directional.ReadValue<Vector2>());
    }

    protected virtual void DoAbility(int index)
    {
        if(abilities.Length >= index)
            abilities[index - 1]?.DoUse(this);

        onUseAbility?.Invoke(index);
        //Debug.Log("Use Ability: " + index);
    }
}
