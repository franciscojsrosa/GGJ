using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
	public GameObject light;
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
		if(textNum == 1)
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
			light.SetActive(false);
		textNum += 1;
	}
}
