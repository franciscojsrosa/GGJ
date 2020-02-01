using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeText4 : MonoBehaviour
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
		terminal.Play();
		if (textNum == 1)
			screenText.text = ">>I can see that didn't go exactly as expected.\n>>But that's okay.";
		if (textNum == 2)
			screenText.text = ">>I can see that didn't go exactly as expected.\n>>But that's okay.\n>>We all make mistakes.";
		if (textNum == 3)
			screenText.text = ">>I can see that didn't go exactly as expected.\n>>But that's okay.\n>>We all make mistakes.\n>>I'm sure you will try not to fuck it up next time.";
		if (textNum == 4)
			screenText.text = ">>I can see that didn't go exactly as expected.\n>>But that's okay.\n>>We all make mistakes.\n>>I'm sure you will try not to fuck it up next time.\n>>Meanwhile, I think you can apologize by fixing the mess you made.";
		if (textNum == 5)
		{
			screenText.text = ">>But that's okay.\n>>We all make mistakes\n>>I'm sure you will try not to fuck it up next time.\n>>Meanwhile, I think you can apologize by fixing the mess you made.\n>>I'll even give you the latest fixing technology, because I'm that generous.";
			fixer.SetActive(true);
		}
		if (textNum == 8)
			SceneManager.LoadScene(nextScene);
		textNum += 1;
	}
}
