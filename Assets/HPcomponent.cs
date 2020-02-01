using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPcomponent : MonoBehaviour
{
    public float currHP;
    public float maxHP;

    void Start()
    {
        maxHP = 10;
        currHP = maxHP;
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
            currHP = 0.05f;
        }
    }

    void Update()
    {
        transform.localScale = new Vector3(transform.localScale.x, (currHP / maxHP), transform.localScale.z);
    }
}
