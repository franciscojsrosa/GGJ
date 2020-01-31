using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{

	public GameObject item;
	public GameObject tempParent;
	public Transform guide;

	private Rigidbody rb;
	private bool isHolding;

    // Start is called before the first frame update
    void Start()
    {
		rb = item.GetComponent<Rigidbody>();
		rb.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnMouseDown()
	{
		if (!isHolding)
		{
			rb.useGravity = false;
			rb.isKinematic = true;
			item.transform.position = guide.transform.position;
			item.transform.rotation = guide.transform.rotation;
			item.transform.parent = tempParent.transform;
			isHolding = true;
		}
		else
		{
			rb.useGravity = true;
			rb.isKinematic = false;
			item.transform.parent = null;
			item.transform.position = guide.transform.position;
			isHolding = false;
		}
	}
}
