using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class ClicksToFinishGame : MonoBehaviour
{
    //variable for total number of clicks
    public int totalClicks;

    // get access to AcornLevelPassed Script
    public AcornCounter acornCounterScript;
    public bool acornCounterBoolTemp;

    void Start()
    {
        // keep this script to the end
        DontDestroyOnLoad(this.gameObject);
        // get reference to script
        acornCounterScript = GameObject.FindObjectOfType<AcornCounter>();
    }

    //void OnGUI()
    //{
    //    // to tell if it was a single click or a double click
    //    Event mouseClicks = Event.current;
    //    if (mouseClicks.isMouse)
    //    {
    //        //Debug.Log("Mouse clicks: " + mouseClicks.clickCount);
    //    }
    //}

    private void Update()
    {
        // get the bool from the other script, which tells us about to load the win screen scene
        acornCounterBoolTemp = GameObject.Find("Acorn Test").GetComponent<AcornCounter>().acornCounterLevelDoneBool;

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

        // show how many clicks total (with right middle or left mouse button)
        Debug.Log("Total Clicks: " + totalClicks);

        if (acornCounterBoolTemp == true)
        {
            ReportTotalClicks(0);
        }

    }

    //if game ends,  ReportLeafLitterClicked(0);

    public void ReportTotalClicks(int totalClickedID)
    {
        // track the event for analytics, which you can find through "go to dashboard" in Services in Unity
        print("totalClicksEvent tracked");
        Analytics.CustomEvent("totalClicksEvent_Clicked", new Dictionary<string, object>
        {
            { "total_clicks_id", totalClickedID },
            { "time_elapsed", Time.timeSinceLevelLoad }
        });
    }


}


