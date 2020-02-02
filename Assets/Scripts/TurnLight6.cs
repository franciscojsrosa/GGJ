using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TurnLight6 : MonoBehaviour
{
	public ChangeMaterial buttonlight;
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

	void OnMouseDown()
	{
		buttonlight.ChangeMat();
		light.SetActive(false);
		//FindObjectOfType<ChangeText>().RoomLight.TurnOff();
		screenText.text = "";
		StartCoroutine(EndCoroutine());
	}

	IEnumerator EndCoroutine()
	{
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene(6);
	}
}
