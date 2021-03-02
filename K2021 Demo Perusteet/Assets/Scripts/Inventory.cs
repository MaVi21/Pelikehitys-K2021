using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public int amountOfLogs = 0;
    public GameObject campfireUI;
    public static bool campfireEnabled = false;

	void PickLog () {

		amountOfLogs = amountOfLogs + 1;

        if(amountOfLogs == 4)
        {
            Debug.Log("campfire creation enabled!");
            campfireEnabled = true;
        }
	}
}
