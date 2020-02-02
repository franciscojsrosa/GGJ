using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour
{
    public float MaxInteractDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonDown(0))
        {
            RaycastHit info;
            if (Physics.Raycast(transform.position, transform.forward, out info, MaxInteractDistance))
            {
                Interactable hit = info.collider.GetComponent<Interactable>();

                Debug.Log(info.collider.gameObject);
                if(hit != null)
                {
                    hit.Interact();
                }
            }
        }
       
    }
}
