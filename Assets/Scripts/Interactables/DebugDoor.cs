using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugDoor : Interactable
{

	public bool notInPlace;

    Animator AnimController;
    // Start is called before the first frame update
    void Start()
    {
        AnimController = GetComponent<Animator>();
    }

    public override void Interact()
    {
		if (!notInPlace)
		{
			base.Interact();
			Debug.Log("lmao");
			AnimController.Play("DoorOpen");
		}
    }
}
