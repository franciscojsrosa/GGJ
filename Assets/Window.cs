﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		this.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.7f);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
