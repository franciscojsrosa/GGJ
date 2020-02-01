using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeText6 : MonoBehaviour
{
	public GameObject player;
	public GameObject fixer;
	public int nextScene;

	public AudioSource terminal;
	private Text screenText;
	private int textNum;

	// Start is called before the first frame update
	void Start()
	{
		screenText = this.GetComponent<Text>();
		textNum = 1;
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnMouseDown()
	{
		Debug.Log(textNum);
		terminal.Play();
		if (textNum == 1)
			screenText.text = ">>I'm bored.\n>>I'm tired of you breaking this game.";
		else if (textNum == 2)
			screenText.text = ">>I'm bored.\n>>I'm tired of you breaking this game.\n>>So I won't show you anything else.";
		else if (textNum == 3)
			screenText.text = ">>I'm bored.\n>>I'm tired of you breaking this game.\n>>So I won't show you anything else.\n>>What, you're saying the game is unfinished?";
		else if (textNum == 4)
			screenText.text = ">>I'm bored.\n>>I'm tired of you breaking this game.\n>>So I won't show you anything else.\n>>What, you're saying the game is unfinished?\n>>It's not unfinished, this is the game.";
		else if (textNum == 5)
			screenText.text = ">>I'm tired of you breaking this game.\n>>So I won't show you anything else.\n>>What, you're saying the game is unfinished?\n>>It's not unfinished, this is the game.\n>>There's nothing else to do.";
		else if (textNum == 6)
			screenText.text = ">>What, you're saying the game is unfinished?\n>>It's not unfinished, this is the game.\n>>There's nothing else to do.\n>>It's just pointing and shooting, for hours and hours.";
		else if (textNum == 7)
			screenText.text = ">>It's not unfinished, this is the game.\n>>There's nothing else to do.\n>>It's just pointing and shooting, for hours and hours.\n>>That will keep you entertained.";
		else
		{
			if (textNum % 2 == 0)
				screenText.text = "";
			else
			{
				if (textNum % 3 == 0)
					screenText.text = ">>Go away.";
				else if (textNum % 7 == 0)
					screenText.text = ">>I'm sick of you.";
				else
					screenText.text = ">>Get out of here";
			}
		}
		textNum += 1;
	}
}
