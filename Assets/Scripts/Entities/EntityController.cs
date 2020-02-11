using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityController : Damageable
{
    public event Action<int> onUseAbility;

    public PlayerGraphics Animator { get; set; }

    public float moveSpeed = 10f;
    public float baseMoveSpeed = 10f;
    public float damageScale = 1;

    [SerializeField]
    protected float rotSpeed = 2f;

    [SerializeField]
    protected Rigidbody body = null;

    [SerializeField]
    protected AbilityBase[] abilities;

    [SerializeField]
    private float inputBufferTime;
    
    private float _inputBufferRetryTime;

    private int _bufferedInput = -1;

    private IEnumerator _bufferedInputRoutine;


    protected virtual void Reset()
    {
        body = GetComponent<Rigidbody>();
    }

    protected override void Start()
    {
        base.Start();
        moveSpeed = baseMoveSpeed;
    }

    protected virtual void DoAbility(int number)
    {
        if (abilities.Length >= number && abilities[number - 1].cooldownRemaining <= 0)
        {
            UseAbility(number);
        }
        else
        {
            _bufferedInput = number;
            _inputBufferRetryTime = abilities[number - 1].cooldownRemaining;
            startBufferTimer();
        }
    }

    private void UseAbility(int number)
    {
        abilities[number - 1].DoUse();

        onUseAbility?.Invoke(number);
    }

    protected virtual void startBufferTimer()
    {
        stopBufferTimer();

        _bufferedInputRoutine = inputBufferTimer();
        StartCoroutine(_bufferedInputRoutine);
    }

    protected virtual void stopBufferTimer()
    {
        if (_bufferedInputRoutine != null)
        {
            StopCoroutine(_bufferedInputRoutine);
        }
    }

    private IEnumerator inputBufferTimer()
    {
        float bufferTimer = inputBufferTime;
        float retryTimer = _inputBufferRetryTime;

        while (retryTimer >= 0)
        {
            retryTimer -= Time.deltaTime;
            bufferTimer -= Time.deltaTime;
            yield return null;
        }

        if (bufferTimer >= 0)
        {
            retryAbility();
        }

        _bufferedInput = -1;
    }

    protected virtual void retryAbility()
    {
        if (_bufferedInput < 0)
        {
            Debug.LogWarning("bufferedInput reset before retrying. this shouldn't happen");
            return;
        }

        DoAbility(_bufferedInput);
    }

    public override void DoDie()
    {
        // Disable our RigidBody on death?
        base.DoDie();
    }
}
