using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRaycast : MonoBehaviour
{
    RaycastHit raycasthit;
    Ray ray; 
    public GameObject text;
    public bool singleShot = false;
    private GameObject messageTrigger;

    // Start is called before the first frame update
    void Start()
    {
        ray = new Ray();
        raycasthit = new RaycastHit();
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out raycasthit, 20f))
        {
            //Debug.Log(raycasthit.transform.gameObject.name);
            if (raycasthit.transform.gameObject.tag == "MessageTrigger")
            {
                if(text.activeSelf == false)
                {
                    ShowMessage();
                    messageTrigger = raycasthit.transform.gameObject;
                }                                       
            }
        }
    }

    private void ShowMessage()
    {
        text.SetActive(true);
        text.GetComponent<Text>().text = "Could try throwing a snowball...";
        Invoke("HideMessage", 3);
    }

    private void HideMessage()
    {
        text.SetActive(false);
        text.GetComponent<Text>().text = "";
        Destroy(text);
        Destroy(this.gameObject);
        //use this version if the trigger has a parent, tag also the parent with the MessageTrigger tag
        Destroy(messageTrigger.transform.GetChild(0).gameObject);
        //use this version if the trigger is a parentless object
        //Destroy(messageTrigger);
    }
}
