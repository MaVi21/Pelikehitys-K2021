using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballThrower : MonoBehaviour {

    public Rigidbody projectile;
	
	void Update () {

        //kuunnellaan fire1-painikkeen input
        if (Input.GetButtonDown("Fire1"))
        {
            //todo: instantioidaan uusi tykinkuula
            //kameran sijaintiin ja kameran rotaatioarvolla
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
