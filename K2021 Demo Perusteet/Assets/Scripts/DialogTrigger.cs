using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Animator animator;
    public BoxCollider triggerCollider;

    void Start()
    {
        //animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            animator.SetTrigger("Sigh");
            //for one shot animation
            Destroy(triggerCollider);
        }
    }

    private void PlaySighAudio()
    {
        GetComponent<AudioSource>().Play();
    }

}
