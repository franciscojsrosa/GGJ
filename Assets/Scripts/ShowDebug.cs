using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Effects;

public class ShowDebug : MonoBehaviour
{
	public GameObject targets;
    public GameObject DebugPortal;
	public GameObject formerGun;
	public GameObject brokenGun;
	public GameObject explodedGun;
	public GameObject gun;
	public GameObject door;

	public int nextScene;

	private bool done;
	private bool doorActive;

	// Start is called before the first frame update
	void Start()
    {
		done = false;
		doorActive = false;
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
				gun.GetComponent<RayCastShootComplete>().enabled = false;
				DebugPortal.SetActive(true);                
				formerGun.SetActive(false);
				brokenGun.SetActive(true);
				explodedGun.SetActive(true);

                GameObject explosionParticleSystem = FindObjectOfType<ParticleSystemMultiplier>().gameObject;
                foreach(Transform system in explosionParticleSystem.transform)
                {
                    system.GetComponent<ParticleSystem>().Play();
                }
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
			if (rot == 3 && !doorActive)
			{
				door.GetComponent<Rigidbody>().isKinematic = false;
				doorActive = true;
			}
			else if (rot >= 4)
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
