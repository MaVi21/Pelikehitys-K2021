using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        //animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            animator.SetTrigger("Sigh");
            //PlaySighAudio();
        }
    }

    private void PlaySighAudio()
    {
        GetComponent<AudioSource>().Play();
    }

}
