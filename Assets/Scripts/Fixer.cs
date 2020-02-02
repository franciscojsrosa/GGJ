using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixer : MonoBehaviour
{
	public GameObject snapPosition1;
	public GameObject snapPosition2;
	public GameObject gun;
	public GameObject gunFragment;

	public GameObject fixedGun;

	private bool snap1;
	private bool snap2;

	// Start is called before the first frame update
	void Start()
    {
		snap1 = true;
		snap2 = true;
    }

    // Update is called once per frame
    void Update()
    {
		if (gun != null && (snapPosition1.transform.position - gun.transform.position).sqrMagnitude < 1 && snap1)
		{
			gun.transform.parent = null;
			gun.GetComponent<MoveObject>().isHolding = false;
			gun.transform.position = snapPosition1.transform.position;
			gun.transform.rotation = new Quaternion(180f, 0f, 0f, 0f);
			snap1 = false;
		}
		if (gunFragment != null && (snapPosition2.transform.position - gunFragment.transform.position).sqrMagnitude < 1 && snap2)
		{
			gunFragment.transform.parent = null;
			gunFragment.GetComponent<MoveObject>().isHolding = false;
			gunFragment.transform.position = snapPosition2.transform.position;
			gunFragment.transform.rotation = new Quaternion(180f, 0f, 0f, 0f);
			snap2 = false;
		}
	}

	void OnMouseDown()
	{
		if(!snap1 && !snap2)
		{
			gun.SetActive(false);
			gunFragment.SetActive(false);
			fixedGun.SetActive(true);
			snap1 = true;
			snap2 = true;
            FindObjectOfType<AKcontroller>().notBroken = true;
		}
	}
}
