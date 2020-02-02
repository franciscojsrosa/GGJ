using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapCover : SnapToTarget
{

    public override void Start()
    {
        base.Start();
    }
    public override void Snap()
    {
        base.Snap();
        FindObjectOfType<AKcontroller>().coverSet = true;
    }
}
