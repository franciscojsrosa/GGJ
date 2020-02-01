using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{

	public GameObject tempParent;

	private Rigidbody rb;
	public bool isHolding;

    // Start is called before the first frame update
    void Start()
    {
		rb = gameObject.GetComponent<Rigidbody>();
		rb.useGravity = true;
		isHolding = false;
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(1))
		{
			if(isHolding)
			{
				rb.useGravity = true;
				rb.isKinematic = false;
                gameObject.transform.parent = null;
                gameObject.transform.position = tempParent.transform.position;
				isHolding = false;
				return;
			}

			var mainCamera = FindCamera();

			// We need to actually hit an object
			RaycastHit hit = new RaycastHit();
			if (
				!Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition).origin,
								 mainCamera.ScreenPointToRay(Input.mousePosition).direction, out hit, 3,
								 Physics.DefaultRaycastLayers))
			{
				return;
			}
			// We need to hit a rigidbody that is not kinematic
			if (hit.rigidbody == this.GetComponent<Rigidbody>())
			{
				if (!isHolding)
				{
					rb.useGravity = false;
					rb.isKinematic = true;
                    gameObject.transform.position = tempParent.transform.position;
					if (gameObject.tag == "Gun")
					{
                        gameObject.transform.rotation = tempParent.transform.rotation;
					}
                    gameObject.transform.parent = tempParent.transform;
					isHolding = true;
					return;
				}
			}
		}
	}

	private Camera FindCamera()
	{
		if (GetComponent<Camera>())
		{
			return GetComponent<Camera>();
		}

		return Camera.main;
	}
}
