using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class ClickTracker : MonoBehaviour
{
    //variable for total number of clicks
    public int totalClicks;

    void Start()
    {
        // keep this script to the end
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        // to tell which of the mouse buttons the player pressed
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Pressed primary button.");
            totalClicks++;
        }

        if (Input.GetMouseButtonDown(1))
        {
            //Debug.Log("Pressed secondary button.");
            totalClicks++;
        }

        if (Input.GetMouseButtonDown(2))
        {
            //Debug.Log("Pressed middle click.");
            totalClicks++;
        }
    }
}


