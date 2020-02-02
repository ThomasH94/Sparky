using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum FacingDirection
//{
//    Down, Left, Up, Right
//}

public class EntityController : Damageable
{
    //public Action<FacingDirection> onFacingDirectionUpdated;
    //[HideInInspector]
    public float moveSpeed = 10f;
    public float baseMoveSpeed = 10f;

    [SerializeField]
    protected float rotSpeed = 2f;
    //public FacingDirection facingDirection;

    [SerializeField]
    protected Rigidbody body = null;
    [SerializeField]
    protected float attackRange = 2f;

    protected Transform lookAt;

    protected virtual void Reset()
    {
        body = GetComponent<Rigidbody>();
    }

    protected override void Start()
    {
        base.Start();
        moveSpeed = baseMoveSpeed;

        lookAt = new GameObject(gameObject.name + "_LookAt").transform;
        lookAt.gameObject.hideFlags = HideFlags.HideInHierarchy;
    }

   

    //protected virtual void SetFacingDirection(Vector2 dir)
    //{
    //    if (dir.y > .01f)
    //        facingDirection = FacingDirection.Up;
    //    else if (dir.y < -.01f)
    //        facingDirection = FacingDirection.Down;
    //    else if (dir.x > .01f)
    //        facingDirection = FacingDirection.Right;
    //    else if (dir.x < -.01f)
    //        facingDirection = FacingDirection.Left;

    //    onFacingDirectionUpdated?.Invoke(facingDirection);
    //}
}
