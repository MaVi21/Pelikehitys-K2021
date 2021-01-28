using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidObject : MonoBehaviour {
		

	//herätefunktio, joka tarkkailee törmäyksiä
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player") {

			//etsitään main camera -peliobjekti, ja lähetetään viesti handleerror
			GameObject.Find ("Main Camera").SendMessage ("HandleError");
		}
	}
}
