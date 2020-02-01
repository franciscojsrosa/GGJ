using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : MonoBehaviour
{

	public GameObject light;
	public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnMouseDown()
	{
		if((light.transform.position - player.transform.position).sqrMagnitude < 2)
			light.SetActive(true);
	}
}
