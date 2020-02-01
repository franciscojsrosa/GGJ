using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeText5 : MonoBehaviour
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
			screenText.text = ">>Oh God, what is it now?\n>>What do you mean, the enemy doesn't have a health thingy?\n";
		if (textNum == 2)
			screenText.text = ">>Oh God, what is it now?\n>>What do you mean, the enemy doesn't have a health thingy?\n>>Of course he's got a health thingy, that's ridiculous.";
		if (textNum == 3)
		{
			screenText.text = ">>What do you mean, the enemy doesn't have a health thingy?\n>>Of course he's got a health thingy, that's ridiculous.\n>>Ugh, fine, I'll give you another one, but you're lucky I'm not charging anything.";
			fixer.SetActive(true);
		}
		textNum += 1;
	}
}
