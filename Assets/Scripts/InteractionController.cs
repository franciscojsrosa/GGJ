using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour
{
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit info;
            if (Physics.Raycast(transform.position, transform.forward, out info))
            {
                Interactable hit = info.collider.GetComponent<Interactable>();
                if(hit != null)
                {
                    hit.Interact();
                }
            }
        }
       
    }
}
