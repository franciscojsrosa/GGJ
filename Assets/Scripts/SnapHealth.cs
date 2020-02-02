using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapHealth : MonoBehaviour
{
	public GameObject health;

	// Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		if ((health.transform.position - this.transform.position).sqrMagnitude < 2)
		{
			health.GetComponent<MoveObject>().isHolding = false;

			health.transform.parent = this.transform;
		}
    }
}
