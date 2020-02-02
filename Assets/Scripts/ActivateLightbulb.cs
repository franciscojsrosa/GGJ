using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLightbulb : SnapToTarget
{
    void Start()
    {
        SnapTarget = FindObjectOfType<LightbulbHolder>().transform;
        SnapDistance = 0.5f;
    }
    void Update()
    {

        if (WithinRange())
        {
            Snap();
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

      
}
