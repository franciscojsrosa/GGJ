using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLightbulb : MonoBehaviour
{
    private Transform target;
    private void Start()
    {
        target = FindObjectOfType<LightbulbHolder>().transform;
    }
    void Update()
    {

        if ((target.position - transform.position).sqrMagnitude < 0.85)
        {
            transform.parent = null;
            transform.position = target.position;
            transform.rotation = new Quaternion(180f, 0f, 0f, 0f);
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
