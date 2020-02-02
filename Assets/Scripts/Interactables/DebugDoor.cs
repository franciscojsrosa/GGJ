using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugDoor : Interactable
{

    Animator AnimController;
    // Start is called before the first frame update
    void Start()
    {
        AnimController = GetComponent<Animator>();
    }

    public override void Interact()
    {
        base.Interact();
        Debug.Log("lmao");
        AnimController.Play("DoorOpen");
    }
}
