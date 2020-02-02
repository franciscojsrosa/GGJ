using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TurnLight : MonoBehaviour
{
    public ChangeMaterial buttonlight;
	public GameObject light;
	public GameObject player;
	public GameObject screen;

	public AudioSource turningOn;

	public AudioSource buzz;
	private Text screenText;

    private bool turnedOn = false;


	// Start is called before the first frame update
	void Start()
	{
		screenText = screen.GetComponent<Text>();
	}


	void OnMouseDown()
	{
		if ((light.transform.position - player.transform.position).sqrMagnitude < 1 && !turnedOn)
        {
            turnedOn = true;
            buttonlight.ChangeMat();
            light.SetActive(true);
            FindObjectOfType<ChangeText>().RoomLight.TurnOn();
            screenText.text = ">>Debug mode activated\n>>AI Supervisor initiated\n>>Please press Left Mouse Button to Continue...";
			turningOn.Play();
			buzz.Play();
		}
        else if (turnedOn)
        {
            buttonlight.ChangeMat();
            light.SetActive(false);
            FindObjectOfType<ChangeText>().RoomLight.TurnOff();
            screenText.text = "";
			StartCoroutine(EndCoroutine());
        }
	}

	IEnumerator EndCoroutine()
	{
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene(6);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(5);
    }
}
