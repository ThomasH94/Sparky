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

    public float moveSpeed = 10f;

    [SerializeField]
    private float rotSpeed = 2f;
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

    protected virtual void Start()
    {
        lookAt = new GameObject(gameObject.name + "_LookAt").transform;
        lookAt.gameObject.hideFlags = HideFlags.HideInHierarchy;
    }

    protected virtual void FixedUpdate()
    {

    }

    protected virtual void Move(Vector3 directionalInput)
    {
        if (Math.Abs(directionalInput.x) > .01f || Math.Abs(directionalInput.y) > .01f)
        {
            //if (body.velocity.magnitude < moveSpeed)
            //    body.AddForce(directionalInput.normalized * moveSpeed * 100f * Time.deltaTime);
            Vector3 newDir = new Vector3(directionalInput.normalized.x, 0, directionalInput.normalized.y);
            body.MovePosition(body.position + newDir * moveSpeed * Time.deltaTime);

            lookAt.position = body.position;
            lookAt.LookAt(body.position + newDir);
            transform.rotation = Quaternion.Lerp(transform.rotation, lookAt.rotation, rotSpeed);

            //body.SetRotation(Mathf.Lerp(body.rotation, Vector3.SignedAngle(Vector3.up, directionalInput, Vector3.forward), rotSpeed));
            //transform.forward = newDir;
            //Vector2.Lerp(transform.up, directionalInput, rotSpeed);

            //SetFacingDirection(directionalInput);
        }
        //else
        //    body.velocity = Vector3.zero;
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
