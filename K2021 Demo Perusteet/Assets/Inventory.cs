﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public int amountOfLogs = 0;
    public GameObject campfireUI;

	void PickLog () {

		amountOfLogs = amountOfLogs + 1;

        if(this.amountOfLogs == 4)
        {
            Debug.Log("campfire creation enabled!");
            //GetComponent<PlayerInput>().enabled = true;
            campfireUI.SetActive(true);
        }
	}
}
