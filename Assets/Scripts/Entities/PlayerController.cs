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
    public event Action onMove;
    public Action<PlayerController> CurrentInteractAction;

    [SerializeField]
    private CameraController cameraPrefab;

    [NonSerialized]
    public bool inputEnabled;
    protected Transform lookAt;

    [SerializeField]
    private PlayerInventory _playerInventory = new PlayerInventory();
    public PlayerInventory PlayerInventory {
        get => _playerInventory;
    }

    private Vector3 spawnPosition;

    public Input input;
    protected override void Start()
    {
        base.Start();
        InitializeInput();

        lookAt = new GameObject(gameObject.name + "_LookAt").transform;
        lookAt.gameObject.hideFlags = HideFlags.HideInHierarchy;

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

        input.playerControls.Reset.performed += context => transform.position = new Vector3(spawnPosition.x, 2f, spawnPosition.z);
        input.playerControls.Quit.performed += context => Application.Quit();

        input.playerControls.Interact.performed += DoInteract;

        input.Enable();
        inputEnabled = true;
    }

    private void DoInteract(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        CurrentInteractAction?.Invoke(this);
        CurrentInteractAction = null;
    }

    private void FixedUpdate()
    {
        Move(input.playerControls.directional.ReadValue<Vector2>());
    }

    protected virtual void Move(Vector3 directionalInput)
    {
        if (Math.Abs(directionalInput.x) > .01f || Math.Abs(directionalInput.y) > .01f)
        {
            Vector3 newDir = new Vector3(directionalInput.normalized.x, 0, directionalInput.normalized.y);
            body.MovePosition(body.position + newDir * moveSpeed * Time.deltaTime);

            lookAt.position = body.position;
            lookAt.LookAt(body.position + newDir);
            transform.rotation = Quaternion.Lerp(transform.rotation, lookAt.rotation, rotSpeed);

            onMove?.Invoke();
        }
    }

    public override void DoDie()
    {
        base.DoDie();

        input.Disable();
        inputEnabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("OutOfBounds"))
        {
            //Debug.LogError("Out");

            QuestTracker.Instance.ranAway = true;
            QuestTracker.Instance.CheckForEnding();
        }
    }
}
