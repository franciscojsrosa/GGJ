using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Effects;

public class AKcontroller : RayCastShootComplete
{

    public GameObject formerGun;
    public GameObject brokenGun;
    public GameObject explodedGun;
    
    public bool coverSet;
    public bool notBroken;

    private int numBullets;
    void Start()
    {
        coverSet = false;
        notBroken = true;
        numBullets = 30;
    }

    public override void Update()
    {
        if (notBroken)
            if(base.ShotInput())
                if (CanShoot())
                {
                    base.Shoot();
                    numBullets--;
                }
                else
                {
                    Explode();
                }
        Debug.Log(numBullets);
    }


    void Explode()
    {
        notBroken = false;
        formerGun.SetActive(false);
        brokenGun.SetActive(true);
        explodedGun.SetActive(true);
        explodedGun.transform.position = formerGun.transform.position;
        GameObject explosionParticleSystem = FindObjectOfType<ParticleSystemMultiplier>().gameObject;
        foreach (Transform system in explosionParticleSystem.transform)
        {
            system.GetComponent<ParticleSystem>().Play();
        }
    }

    public override bool CanShoot()
    {
        return base.CanShoot() && numBullets > 0 && coverSet;
    }

    
}
