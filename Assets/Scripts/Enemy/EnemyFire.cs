using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject player;
    private bool lineOfSight = false;

    public float weaponRange = 100f;
    public float reload = 0.5f;
    private Vector3 currPos;

    public GameObject projectile;
    private float curr;

    // Start is called before the first frame update
    void Start()
    {
        curr = Time.time;
        currPos = this.transform.position;
        ShootPlayer();

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - curr > reload){
            ShootPlayer();
            curr = Time.time;
        }
    }

    void ShootPlayer(){
        // Play the shooting sound effect
		//gunAudio.Play ();

        GameObject bullet = Instantiate(projectile, this.transform.position, this.transform.rotation) as GameObject;

        bullet.GetComponent<Rigidbody>().AddForce(new Vector3(100,0,0));
    }

}   
