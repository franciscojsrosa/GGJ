using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShootableBox2 : MonoBehaviour {

	//The box's current health point total
	public int currentHealth = 3;
    public HPcomponent hp;

	public void Damage(int damageAmount)
	{
        hp.LowerHP(damageAmount);
        if (hp.noHP)
        {
            this.GetComponent<Rigidbody>().isKinematic = false;
        }

		//Check if health has fallen below zero
		//if health has fallen below zero, deactivate it 

		//gameObject.SetActive (false);
	}

	void Update(){	

	}
}
