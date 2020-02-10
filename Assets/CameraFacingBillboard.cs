using UnityEngine;
using System.Collections;
 
public class CameraFacingBillboard : MonoBehaviour
{
    Quaternion initialRotation;

    void Start()
    {
        initialRotation = transform.rotation;
    }

    //Orient the camera after all movement is completed this frame to avoid jittering
    void LateUpdate()
    {
        transform.rotation = initialRotation;
    }
}