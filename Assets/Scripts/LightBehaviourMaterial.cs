using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehaviourMaterial : LightBehaviour
{
    public Material LightOn;
    public Material LightOff;

    MeshRenderer meshRenderer;
    void Start() 
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public override void TurnOff()
    {
        meshRenderer.material = LightOff;
        foreach (Transform child in transform)
            child.GetComponent<LightBehaviour>().TurnOff();
    }

    public override void TurnOn()
    {
        meshRenderer.material = LightOn;
        foreach (Transform child in transform)
            child.GetComponent<LightBehaviour>().TurnOn();
    }


}
