using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceHint : MonoBehaviour
{
    public GameObject hintObject;
    private Transform player;
    private GameObject hint;
    private Canvas canvas;
    private RectTransform canvasRect;
    private Text distanceText;
    private Renderer objectRenderer;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        this.hint = Instantiate(hintObject, transform.position, Quaternion.identity);
        distanceText = hint.GetComponent<Text>();
        canvas = (Canvas)FindObjectOfType(typeof(Canvas));
        hint.transform.parent = canvas.transform;
        canvasRect = canvas.GetComponent<RectTransform>();
        objectRenderer = GetComponent<Renderer>();

        if (objectRenderer.isVisible)
        {
            distanceText.enabled = true;
        }
        else
        {
            distanceText.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(Vector3.Distance(player.position, transform.position));
        if (hint.activeSelf)
        {
            distanceText.text = Vector3.Distance(player.position, transform.position).ToString("0") + " m";
            // Offset position above object bbox (in world space)
            float offsetPosY = this.transform.position.y + 2f;
            // Final position of marker above GO in world space
            Vector3 offsetPos = new Vector3(this.transform.position.x, offsetPosY, this.transform.position.z);
            // Calculate *screen* position (note, not a canvas/recttransform position)
            Vector2 canvasPos;
            Vector2 screenPoint = Camera.main.WorldToScreenPoint(offsetPos);
            // Convert screen position to Canvas / RectTransform space <- leave camera null if Screen Space Overlay
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRect, screenPoint, null, out canvasPos);
            hint.transform.localPosition = canvasPos;
        }
    }

    /*Turn off shadows of the observed object, otherwise this may not work*/
    void OnBecameInvisible()
    {
        //Debug.Log("invisible");
        distanceText.enabled = false;
    }

    void OnBecameVisible()
    {
        //Debug.Log("visible");
        distanceText.enabled = true;
    }
}
