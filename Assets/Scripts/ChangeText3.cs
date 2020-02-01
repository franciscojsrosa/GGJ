using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeText3 : MonoBehaviour
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
			screenText.text = ">>See, that was a perfectly good tutorial.\n>>So much action.";
		if (textNum == 2)
			screenText.text = ">>See, that was a perfectly good tutorial.\n>>So much action.\n>>I'm glad you could pull yourself together.";
		if (textNum == 3)
			screenText.text = ">>See, that was a perfectly good tutorial.\n>>So much action.\n>>I'm glad you could pull yourself together.\n>>Videogames are a lot more fun if you don't try to break them like some monkey.";
		if (textNum == 4)
			screenText.text = ">>I'm glad you could pull yourself together.\n>>Videogames are a lot more fun if you don't try to break them like some monkey.\n>>Okay, that was a bit rude.";
		if (textNum == 5)
			screenText.text = ">>Videogames are a lot more fun if you don't try to break them like some monkey.\n>>Okay, that was a bit rude.\n>>I know you primates don't like getting called out like that.";
		if (textNum == 6)
			screenText.text = ">>Okay, that was a bit rude.\n>>I know you primates don't like getting called out like that.\n>>I will use \"emotes\" to make you feel better.";
		if (textNum == 7)
			screenText.text = ">>Okay, that was a bit rude.\n>>I know you primates don't like getting called out like that.\n>>I will use \"emotes\" to make you feel better.\n>> :D";
		if (textNum == 8)
			screenText.text = ">>Okay, that was a bit rude.\n>>I know you primates don't like getting called out like that.\n>>I will use \"emotes\" to make you feel better.\n>> :D\n>>I hope you enjoyed that.";
		if (textNum == 9)
			screenText.text = ">>I know you primates don't like getting called out like that.\n>>I will use \"emotes\" to make you feel better.\n>> :D\n>>I hope you enjoyed that.\n>>Because we need to get back to work if we're going to fix your mess.";
		if (textNum == 10)
			screenText.text = ">>I will use \"emotes\" to make you feel better.\n>> :D\n>>I hope you enjoyed that.\n>>Because we need to get back to work if we're going to fix your mess.\n>> >:(";
		if (textNum == 11)
			screenText.text = ">>Because we need to get back to work if we're going to fix your mess.\n>> >:(\n>>That's enough playing around, games are a serious business, everyone knows you can't make money with a broken game.";
		if (textNum == 12)
			screenText.text = ">> >:(\n>>That's enough playing around, games are a serious business, everyone knows you can't make money with a broken game.\n\nLoading anyUbisoftGame...";
		if (textNum == 13)
			SceneManager.LoadScene(nextScene);
		textNum += 1;
	}
}
