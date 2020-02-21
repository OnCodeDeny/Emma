using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcornCounter : MonoBehaviour
{
    //Set Variables
    public static int amount;
    public Text textComponent;
    ObjectDetector playerDetector;
    GameObject player;

    // Get the distance from the player to the object
    void Start()
    {
        playerDetector = transform.Find("PlayerDetector").gameObject.GetComponent<ObjectDetector>();
        player = GameObject.Find("Emma");
    }

    // Counts upwards when an acorn is collected
    void Update()
    {
        textComponent.text = "Acorns: " + amount;
    }

    // When an acorn is clicked, it gets added to the counter
    void OnMouseDown()
    {
        if (playerDetector.isObjectInRange)
        {
            if (gameObject.tag == "Acorn")
            {
                amount++;
            }
        }
    }
}
