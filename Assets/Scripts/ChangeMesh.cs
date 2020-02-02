using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMesh : MonoBehaviour
{
    public Mesh mesh1;
    public Mesh mesh2;



    public void GetADoor()
    {
        GetComponent<MeshFilter>().mesh = mesh2;
        GetComponent<MeshCollider>().sharedMesh = mesh2;
    }

    void Update()
    {
    }
}
