using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToTarget : MonoBehaviour
{
    public Transform SnapTarget;

    public float SnapDistance;

    Transform Parent;
    public virtual void Start()
    {
        if (transform.parent != null)
            Parent = transform.parent;
    }

    public virtual void Update()
    {
        if (WithinRange())
        {
            Snap();
        }
    }

    public bool WithinRange()
    {
        return (transform.position - SnapTarget.position).sqrMagnitude < SnapDistance * SnapDistance;
    }
    
    public virtual void Snap()
    {
        gameObject.GetComponent<MoveObject>().enabled = false;
        //Object held has the hand as it's parent so remove it
        transform.parent = null;
        
        transform.position = SnapTarget.position;
        transform.rotation = SnapTarget.rotation;  
    }
}
