using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapHealth : MonoBehaviour
{
	public GameObject health;

	private Vector3 snapPosition;
    // Start is called before the first frame update
    void Start()
    {
		snapPosition = new Vector3(-0.0720005f, 1.219f, -0.455f);
    }

    // Update is called once per frame
    void Update()
    {
		if ((health.transform.position - this.transform.position + snapPosition).sqrMagnitude < 2)
		{
			health.GetComponent<MoveObject>().isHolding = false;

			health.transform.parent = this.transform;
		}
    }
}
