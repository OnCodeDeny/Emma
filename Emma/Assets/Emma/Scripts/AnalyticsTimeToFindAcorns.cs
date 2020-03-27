using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class AnalyticsTimeToFindAcorns : MonoBehaviour
{
    private static int amount;

    void Start()
    {
        ReportTimeTaken(GameObject.Find("Time Tracker").GetComponent<Timer>().time);
    }
    
    // Update is called once per frame
    void Update()
    {
        amount = AcornCounter.amount;

        // If the player collects 6 acorns, report the time taken to do so
        if (amount == 6)
        {
            ReportTimeTaken(GameObject.Find("Time Tracker").GetComponent<Timer>().time);
        }
    }


    // Report the analytics when the player completes the specified events
    public void ReportTimeTaken(float timeTaken)
    {
        Analytics.CustomEvent("time_completed", new Dictionary<string, object>
        {
            { "acorns_found", timeTaken },
            { "time_elapsed", Time.timeSinceLevelLoad }
        });
    }
}
