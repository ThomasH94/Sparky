using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nopejs : MonoBehaviour
{
    float nopeSpeed = 1;

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up * nopeSpeed);
    }
}
