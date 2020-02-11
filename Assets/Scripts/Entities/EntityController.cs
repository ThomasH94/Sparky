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
            abilities[number - 1].DoUse();

            onUseAbility?.Invoke(number);
        }
    }
}
