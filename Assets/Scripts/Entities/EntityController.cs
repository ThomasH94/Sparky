using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FacingDirection
{
    Down, Left, Up, Right
}

public class EntityController : Damageable
{
    public float moveSpeed = 10f;
    public FacingDirection facingDirection;

    [SerializeField]
    protected Rigidbody2D body = null;

    protected virtual void FixedUpdate()
    {
        
    }

    protected virtual void Move(Vector2 directionalInput)
    {
        if (Math.Abs(directionalInput.x) > .01f || Math.Abs(directionalInput.y) > .01f)
        {
            body.MovePosition(body.position + directionalInput.normalized * moveSpeed * Time.deltaTime);

            SetFacingDirection(directionalInput);
        }
    }

    protected virtual void SetFacingDirection(Vector2 dir)
    {
        if (dir.y > .01f)
            facingDirection = FacingDirection.Up;
        else if (dir.y < -.01f)
            facingDirection = FacingDirection.Down;
        else if (dir.x > .01f)
            facingDirection = FacingDirection.Right;
        else if (dir.x < -.01f)
            facingDirection = FacingDirection.Left;
    }
}
