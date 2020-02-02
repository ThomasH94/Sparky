using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float followSpeed;

    private Transform player;

    public void Initialize(Transform player)
    {
        this.player = player;
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, player.position, followSpeed * Time.fixedDeltaTime);
    }
}
