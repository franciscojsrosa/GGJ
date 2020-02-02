using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLightbulb : SnapToTarget
{
    public override void Start()
    {
        base.Start();
        SnapTarget = FindObjectOfType<LightbulbHolder>().transform;
        SnapDistance = 0.5f;
    }
    public override void Snap()
    {
        base.Snap();
        foreach (Transform child in transform)
        {
            foreach (Transform child2 in child)
            {
                child2.gameObject.SetActive(true);
            }
        }
        FindObjectOfType<ChangeText>().LightIsHere();
    }
}