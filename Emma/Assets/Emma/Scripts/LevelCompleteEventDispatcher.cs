using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;


public class LevelCompleteEventDispatcher : MonoBehaviour
{
    ClickTracker ct;
    // Start is called before the first frame update
    void Start()
    {
        //Reference the player click tracker in the scene
        ct = GameObject.Find("Click Tracker").GetComponent<ClickTracker>();

        //Parameter : total_clicks, represents the total number of mouse click action in the game
        //This is a standard unity analytics event with additional parameter
        AnalyticsResult result = AnalyticsEvent.LevelComplete("acorner_level", new Dictionary<string, object> { { "total_clicks", ct.totalClicks } });
        Debug.Log("Level complete event " + result);
    }
}
