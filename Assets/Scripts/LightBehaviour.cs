using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehaviour : MonoBehaviour
{
    Light lightObj;
    // Start is called before the first frame update
    void Start()
    {
        lightObj = GetComponent<Light>();
    }

    public virtual void TurnOff() 
    {
        lightObj.enabled = false;
    }

    public virtual void TurnOn()
    {
        lightObj.enabled = false;
    }
}
