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
	public GameObject door;

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
		if (textNum < 6)
		{
			Debug.Log(textNum);
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
			textNum += 1;
		}
		else if (!door.GetComponent<Rigidbody>().isKinematic)
		{
			if (textNum == 6)
				screenText.text = ">>I'm sure you will try not to fuck it up next time.\n>>Meanwhile, I think you can apologize by fixing the mess you made.\n>>I'll even give you the latest fixing technology, because I'm that generous.\n>>You can't shoot the last target?";
			if (textNum == 7)
				screenText.text = ">>Meanwhile, I think you can apologize by fixing the mess you made.\n>>I'll even give you the latest fixing technology, because I'm that generous.\n>>You can't shoot the last target?\n>>You can clearly see it from the window.";
			if (textNum == 8)
				screenText.text = ">>I'll even give you the latest fixing technology, because I'm that generous.\n>>You can't shoot the last target?\n>>You can clearly see it from the window.\n>>I'm sure you can shoot through a window, that would make sense.";
			if (textNum == 9)
			{
				screenText.text = ">>You can't shoot the last target?\n>>You can clearly see it from the window.\n>>I'm sure you can shoot through a window, that would make sense.\n>>And if you can't, just walk inside the room, dummy.";
				door.SetActive(true);
			}
			textNum += 1;
		}
	}
}
