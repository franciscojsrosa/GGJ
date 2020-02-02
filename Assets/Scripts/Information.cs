using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Information : MonoBehaviour
{
	public Text info;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

		var mainCamera = FindCamera();

		RaycastHit hit = new RaycastHit();
		if (
			!Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition).origin,
							 mainCamera.ScreenPointToRay(Input.mousePosition).direction, out hit, 2,
							 Physics.DefaultRaycastLayers))
		{
			info.text = "";
		}
		else
		{
			if (hit.transform.tag == "Gun")
			{
				info.text = "Pick up (Right Mouse Button)";
			}
			if (hit.transform.tag == "Grab")
			{
				info.text = "Pick up (Right Mouse Button)";
			}
			if (hit.transform.tag == "Interact")
			{
				info.text = "Interact (Left Mouse Button)";
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
