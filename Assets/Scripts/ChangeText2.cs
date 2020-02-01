using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeText2 : MonoBehaviour
{
    public LightBehaviourMaterial RoomLight;
	public GameObject pcLight;
	public GameObject player;
	public GameObject lightbulb;
	public GameObject spotlight;
	public int nextScene;

	public AudioSource screw;

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
		if (pcLight.activeSelf)
		{
			terminal.Play();
			if (textNum == 1)
				screenText.text = "Exception - Failed to load de_dust2\n>>What?";
			if (textNum == 2)
				screenText.text = "Exception - Failed to load de_dust2\n>>What?\n>>Why are you back here already?";
			if (textNum == 3)
				screenText.text = "Exception - Failed to load de_dust2\n>>What?\n>>Why are you back here already?\n>>Oh, nevermind, that was the wrong game.";
			if (textNum == 4)
				screenText.text = "Exception - Failed to load de_dust2\n>>What?\n>>Why are you back here already?\n>>Oh, nevermind, that was the wrong game.\n>>I think.";
			if (textNum == 5)
				screenText.text = "Exception - Failed to load de_dust2\n>>What?\n>>Why are you back here already?\n>>Oh, nevermind, that was the wrong game.\n>>I think.\n>>Let me just double check that.";
			if (textNum == 6)
				screenText.text = ">>What?\n>>Why are you back here already?\n>>Oh, nevermind, that was the wrong game.\n>>I think.\n>>Let me just double check that.\n>>Okay, now I'm sure, let's get back to business.";
			if (textNum == 7)
				screenText.text = ">>Oh, nevermind, that was the wrong game.\n>>I think.\n>>Let me just double check that.\n>>Okay, now I'm sure, let's get back to business.\n\nLoading raidshadowlegends...";
			if (textNum == 8)
				SceneManager.LoadScene(nextScene);
			textNum += 1;
		}
	}
}
