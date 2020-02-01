using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeText3 : MonoBehaviour
{
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
        screenText.text = ">>So, that's it for our wonderful tutorial.";
		textNum = 2;
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
				screenText.text = ">>So, that's it for our wonderful tutorial.";
			if (textNum == 2)
				screenText.text = ">>So, that's it for our wonderful tutorial.\n>>What are you waiting for?";
			if (textNum == 3)
				screenText.text = ">>So, that's it for our wonderful tutorial.\n>>What are you waiting for?\n>>You can leave now.";
			if (textNum == 4)
				screenText.text = ">>So, that's it for our wonderful tutorial.\n>>What are you waiting for?\n>>You can leave now.\n>>I'm serious.";
			if (textNum == 5)
				screenText.text = ">>So, that's it for our wonderful tutorial.\n>>What are you waiting for?\n>>You can leave now.\n>>I'm serious.\n>>Do you enjoy my company this much?";
			if (textNum == 6)
				screenText.text = ">>So, that's it for our wonderful tutorial.\n>>What are you waiting for?\n>>You can leave now.\n>>I'm serious.\n>>Do you enjoy my company this much?\n>>The game has ended.";
			if (textNum == 7)
				screenText.text = ">>What are you waiting for?\n>>You can leave now.\n>>I'm serious.\n>>Do you enjoy my company this much?\n>>The game has ended.\n>>They didn't have time to develop anything else.";
			if (textNum == 8)
				screenText.text = ">>You can leave now.\n>>I'm serious.\n>>Do you enjoy my company this much?\n>>The game has ended.\n>>They didn't have time to develop anything else.\n>>Goodbye now.";
            if (textNum == 9)
                SceneManager.LoadScene(nextScene);    
			textNum += 1;
		}
	}
}
