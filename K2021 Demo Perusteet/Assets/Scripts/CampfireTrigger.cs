using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampfireTrigger : MonoBehaviour
{
    public GameObject campfireUI;
    public GameObject player;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && Inventory.campfireEnabled)
        {
            campfireUI.SetActive(true);
            player.GetComponent<PlayerInput>().enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            campfireUI.SetActive(false);
            player.GetComponent<PlayerInput>().enabled = false;
        }
    }

}
