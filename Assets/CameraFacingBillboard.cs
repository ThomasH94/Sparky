using UnityEngine;
using System.Collections;
 
public class CameraFacingBillboard : MonoBehaviour
{
    private Quaternion _initialRotation;

    void Start()
    {
        _initialRotation = transform.rotation;
    }

    //Orient the camera after all movement is completed this frame to avoid jittering
    void LateUpdate()
    {
        transform.rotation = _initialRotation;
    }
}