using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float speed = 0.125f;//camera adjustion speed
    public Vector3 cameraOffset;

    private void LateUpdate()
    {
        transform.position = target.position + cameraOffset;// postion camera relative to player at a given offset
    }
}

