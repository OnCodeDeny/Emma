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
        ct = GameObject.Find("Click Tracker").GetComponent<ClickTracker>();

        AnalyticsResult result = AnalyticsEvent.LevelComplete("acorner_level", new Dictionary<string, object> { { "total_clicks", ct.totalClicks } });
        Debug.Log("Level complete event " + result);
    }
}
