using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeText : MonoBehaviour
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
		if(lightbulb != null && (lightbulb.transform.position - spotlight.transform.position).sqrMagnitude < 1 && spotlight.activeSelf)
		{
			lightbulb.transform.parent = null;
			lightbulb.transform.position = spotlight.transform.position;
			lightbulb.transform.rotation = new Quaternion(180f, 0f, 0f, 0f);
			spotlight.SetActive(false);
			screw.Play();
			textNum = 1;
			terminal.Play();	
			screenText.text = ">>This is the Debug Room, you're not supposed to be here at all.\n>>Oh God, my boss is gonna kill me.\n>>And the lightbulb went out again.\n>>Could you please fix that?\n>>Thanks for that one.";
		}
    }

	void OnMouseDown()
	{
		if (!spotlight.activeSelf)
		{
			terminal.Play();
			if (textNum == 1)
				screenText.text = ">>Oh God, my boss is gonna kill me.\n>>And the lightbulb went out again.\n>>Could you please fix that?\n>>Thanks for that one.\n>>You might have figured out this isn't the actual game by now.";
			if (textNum == 2)
				screenText.text = ">>Could you please fix that?\n>>Thanks for that one.\n>>You might have figured out this isn't the actual game by now.\n>>No one has played this game in a while, some things might not work right.";
			if (textNum == 3)
				screenText.text = ">>Thanks for that one.\n>>You might have figured out this isn't the actual game by now.\n>>No one has played this game in a while, some things might not work right.\n>>I would appreciate your understanding.";
			if (textNum == 4)
				screenText.text = ">>You might have figured out this isn't the actual game by now.\n>>No one has played this game in a while, some things might not work right.\n>>I would appreciate your understanding.\n>>And maybe I could use some help.";
			if (textNum == 5)
				screenText.text = ">>No one has played this game in a while, some things might not work right.\n>>I would appreciate your understanding.\n>>And maybe I could use some help.\n>>Nah, forget that, this will work fine.";
			if (textNum == 6)
				screenText.text = ">>I would appreciate your understanding.\n>>And maybe I could use some help.\n>>Nah, forget that, this will work fine.\n>>Let me just send you on the right way.";
			if (textNum == 7)
				screenText.text = ">>I would appreciate your understanding.\n>>And maybe I could use some help.\n>>Nah, forget that, this will work fine.\n>>Let me just send you on the right way.\n>>Loading de_dust2...";
			if (textNum == 8)
				SceneManager.LoadScene(nextScene);
			textNum += 1;
		}
		else if (pcLight.activeSelf && textNum < 10)
		{
			terminal.Play();
			if (textNum == 1)
				screenText.text = ">>...";
			if (textNum == 2)
				screenText.text = ">>...\n>>Uhh...";
			if (textNum == 3)
				screenText.text = ">>...\n>>Uhh...\n>>Hello there.";
			if (textNum == 4)
				screenText.text = ">>...\n>>Uhh...\n>>Hello there.\n>>How did you get here?";
			if (textNum == 5)
				screenText.text = ">>...\n>>Uhh...\n>>Hello there.\n>>How did you get here?\n>>This is the Debug Room, you're not supposed to be here at all.";
			if (textNum == 6)
				screenText.text = ">>...\n>>Uhh...\n>>Hello there.\n>>How did you get here?\n>>This is the Debug Room, you're not supposed to be here at all.\n>>Oh God, my boss is gonna kill me.";
            if (textNum == 7)
                RoomLight.TurnOff();
			if (textNum == 8)
				screenText.text = ">>Uhh...\n>>Hello there.\n>>How did you get here?\n>>This is the Debug Room, you're not supposed to be here at all.\n>>Oh God, my boss is gonna kill me.\n>>And the lightbulb went out again.";
			if (textNum == 9)
			{
				screenText.text = ">>How did you get here?\n>>This is the Debug Room, you're not supposed to be here at all.\n>>Oh God, my boss is gonna kill me.\n>>And the lightbulb went out again.\n>>Could you please fix that?";
				lightbulb.SetActive(true);
			}
			textNum += 1;
		}
	}
}
