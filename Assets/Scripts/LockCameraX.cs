using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCameraX : MonoBehaviour
{
    public Transform targetTransform;
    Vector3 tempVec3 = new Vector3();

    void LateUpdate()
    {
        tempVec3.x = this.transform.position.x;
        tempVec3.y = targetTransform.position.y;
        tempVec3.z = this.transform.position.z;
        this.transform.position = tempVec3;
    }
}
