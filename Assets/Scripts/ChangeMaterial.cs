using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{

    public Material redstufs;
    public Material thegudstuf;
    private bool red = true;
    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material = redstufs;
    }
    public void ChangeMat()
    {
        if (red)
        {
            gameObject.GetComponent<MeshRenderer>().material = thegudstuf;
            red = false;
        }

        else
        {
            gameObject.GetComponent<MeshRenderer>().material = redstufs;
            red = true;
        }
    }
}
