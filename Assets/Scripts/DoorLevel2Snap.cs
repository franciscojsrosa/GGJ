using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLevel2Snap : SnapToTarget
{

    public override void Snap()
    {
        base.Snap();
        FindObjectOfType<ChangeMesh>().GetADoor();
    }
}
