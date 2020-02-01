using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShootableBox : MonoBehaviour {

	//The box's current health point total
	public int currentHealth = 3;

	public void Damage(int damageAmount)
	{
		//subtract damage amount when Damage function is called
		currentHealth -= damageAmount;

		if (currentHealth <= 0){
			this.GetComponent<Rigidbody>().isKinematic = false;	
		}

		//Check if health has fallen below zero
		//if health has fallen below zero, deactivate it 

		//gameObject.SetActive (false);
	}

	void Update(){	

	}
}
