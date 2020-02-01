using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowDebug : MonoBehaviour
{
	public GameObject targets;
	public GameObject debugRoom;
	public GameObject formerGun;
	public GameObject brokenGun;
	public GameObject explodedGun;

	public int nextScene;

	private bool done;

	// Start is called before the first frame update
	void Start()
    {
		done = false;   
    }

    // Update is called once per frame
    void Update()
    {
		if (!done)
		{
			int rot = 0;
			foreach (Transform child in targets.transform)
			{
				Rigidbody rb = child.GetComponent<Rigidbody>();
				if (!rb.isKinematic)
				{
					rot += 1;
				}
			}
			if (rot >= 3)
			{
				debugRoom.SetActive(true);
				formerGun.SetActive(false);
				brokenGun.SetActive(true);
				explodedGun.SetActive(true);
				done = true;
			}
		}
		else
		{
			int rot = 0;
			foreach (Transform child in targets.transform)
			{
				Rigidbody rb = child.GetComponent<Rigidbody>();
				if (!rb.isKinematic)
				{
					rot += 1;
				}
			}
			if (rot >= 4)
			{
				SceneManager.LoadScene(nextScene);
			}
		}
    }
}
