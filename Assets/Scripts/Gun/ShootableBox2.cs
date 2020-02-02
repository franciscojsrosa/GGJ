using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShootableBox2 : MonoBehaviour {

	//The box's current health point total
	public int currentHealth = 3;
    public HPcomponent hp;

    private void Start()
    {
        hp.SetHP(currentHealth);
    }
    public void Damage(int damageAmount)
	{
		if (this.transform.Find("Health") != null)
		{
			hp.LowerHP(damageAmount);
			if (hp.noHP)
			{
				this.GetComponent<Rigidbody>().isKinematic = false;
			}
		}
	}

	void Update(){	

	}
}
