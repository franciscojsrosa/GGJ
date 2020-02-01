using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class FallRespawnController : MonoBehaviour
{
    public GameObject player;

    Vector3 SpawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y < -100)
        {
            //Respawn and take away velocity
            player.transform.position = SpawnPosition;
            //player.GetComponent<Rigidbody>().velocity = Vector3.zero;
            player.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
