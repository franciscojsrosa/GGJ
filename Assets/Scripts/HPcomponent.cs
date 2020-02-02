using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPcomponent : MonoBehaviour
{
    public float currHP;
    public float maxHP;
    private float start;
    public bool noHP;

    void Start()
    {
        maxHP = 10;
        currHP = maxHP;
        start = Time.time;
        noHP = false;
    }

    public void SetHP(int hp)
    {
        maxHP = hp;
        currHP = maxHP;
    }

    public void LowerHP(int amount)
    {
        currHP -= amount;
        if (currHP <= 0)
        {
            noHP = true;
            transform.parent.parent.GetComponent<Rigidbody>().isKinematic = false;
            currHP = 0.05f;
        }
    }

    void Update()
    {
        transform.localScale = new Vector3(transform.localScale.x, (currHP / maxHP), transform.localScale.z);
    }
}
