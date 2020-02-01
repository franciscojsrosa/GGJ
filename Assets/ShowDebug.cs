using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDebug : MonoBehaviour
{
	public GameObject targets;
	public GameObject debugRoom;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		int rot = 0;
        foreach(Transform child in targets.transform)
		{
			Rigidbody rb = child.GetComponent<Rigidbody>();
			if (!rb.isKinematic)
			{
				rot += 1;
			}
		}
		if(rot >= 3)
		{
			debugRoom.SetActive(true);
		}
    }
}
