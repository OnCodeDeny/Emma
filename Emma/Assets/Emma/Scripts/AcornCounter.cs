using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcornCounter : MonoBehaviour
{
    //Set Variables
    public static int amount;
    public Text textComponent;

    // Start the game with the amount at 0
    void Awake()
    {
        amount = 0;
    }

    // Counts upwards when an acorn is collected
    void Update()
    {
        textComponent.text = "Acorns: " + amount;
    }

    // When an acorn is clicked, it gets added to the counter
    void OnMouseDown()
    {
        if (gameObject.tag == "Acorn")
        {
            amount++;
        }
    }
}
