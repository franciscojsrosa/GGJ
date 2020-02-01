using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowDebug2 : MonoBehaviour
{
	public GameObject targets;
	public GameObject debugRoom;

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
			if (rot >= 2)
			{
				debugRoom.SetActive(true);
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
			if (rot >= 3)
			{
				StartCoroutine(EndCoroutine());
			}
		}
    }

	IEnumerator EndCoroutine()
	{
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene(nextScene);
	}
}
