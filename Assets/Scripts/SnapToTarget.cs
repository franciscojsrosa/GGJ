using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToTarget : MonoBehaviour
{
    public Transform SnapTarget;

    public float SnapDistance;

    public bool WithinRange()
    {
        return (transform.position - SnapTarget.position).sqrMagnitude < SnapDistance * SnapDistance;
    }
    
    public void Snap()
    {
        //Object held has the hand as it's parent so remove it
        transform.parent = null;

        transform.position = SnapTarget.position;
        transform.rotation = SnapTarget.rotation;
    }
}
