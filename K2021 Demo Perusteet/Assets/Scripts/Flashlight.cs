using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashLight;
    
    // Start is called before the first frame update
    void Start()
    {
        flashLight.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {

            flashLight.SetActive(!flashLight.activeSelf);
        }
    }
}
