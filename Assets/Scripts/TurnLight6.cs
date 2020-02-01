﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnLight6 : MonoBehaviour
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
		light.SetActive(true);
		screenText.text = ">>I'm bored.\n";
		buzz.Play();
	}

	// Update is called once per frame
	void Update()
	{

	}
}
