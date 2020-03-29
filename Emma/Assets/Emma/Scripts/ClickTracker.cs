using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class ClickTracker : MonoBehaviour
{
    //variable for total number of clicks
    public int totalClicks;

    private static int amount;

    void Start()
    {
        // keep this script to the end
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        amount = AcornCounter.amount;

        // If the player collects 6 acorns, report the time taken to do so
        if (amount == 6)
        {
            ReportTotalClicks(GameObject.Find("Click Tracker").GetComponent<ClickTracker>().totalClicks);
        }

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
    }

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


