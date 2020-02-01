using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnLight : MonoBehaviour
{

	public GameObject light;
	public GameObject player;
	public GameObject screen;

	public AudioSource turningOn;

	public AudioSource buzz;
	private Text screenText;

	// Start is called before the first frame update
	void Start()
	{
		screenText = screen.GetComponent<Text>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnMouseDown()
	{
		if ((light.transform.position - player.transform.position).sqrMagnitude < 2)
		{
			light.SetActive(true);
			screenText.text = ">>Debug mode activated\n>>AI Supervisor initiated\n>>Please press Left Mouse Button to Continue...";
			turningOn.Play();
			buzz.Play();
		}
	}
}
