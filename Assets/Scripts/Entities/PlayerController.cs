using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : EntityController
{
    public event Action onMove;
    public Action<PlayerController> CurrentInteractAction;

    [SerializeField]
    private CameraController currentPrefab;

    [SerializeField]
    private CameraController currentCamera;

    public bool inputEnabled { get; set; }

    protected Transform lookAt;

    //[SerializeField] can't with dictionaries :c
    private PlayerInventoryDictionary _playerInventory = new PlayerInventoryDictionary();
    public PlayerInventoryDictionary PlayerInventory {
        get => _playerInventory;
    }

    private Vector3 spawnPosition;

    public Input input;


    private void Awake()
    {
        if (currentCamera == null)
        {
            currentCamera = Instantiate(currentCamera);
        }

        currentCamera.Initialize(transform);

        lookAt = new GameObject(gameObject.name + "_LookAt").transform;
        lookAt.gameObject.hideFlags = HideFlags.HideInHierarchy;
    }

    protected override void Start()
    {
        base.Start();
        InitializeInput();
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

        input.playerControls.Reset.performed += context => transform.position = new Vector3(spawnPosition.x, 2f, spawnPosition.z);
        input.playerControls.Quit.performed += context => SceneLoader.Instance.LoadSceneWithString("MainMenu");

        input.Enable();
        inputEnabled = true;
    }

    private void DoInteract(InputAction.CallbackContext obj)
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
