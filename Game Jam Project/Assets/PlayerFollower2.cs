using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower2 : MonoBehaviour
{
    public Vector3 offset;
    public Transform Target;
    public float DeltaTime = 0;

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,Target.position + offset, DeltaTime);
    }
}
