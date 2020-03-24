using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class AnalyticsTimeToFindAcorns : MonoBehaviour
{
    private static int amount;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        amount = AcornCounter.amount;
        
        if (amount == 6)
        {
            ReportTimeTaken(0);
        }
    }


    public void ReportTimeTaken(float timeTaken)
    {
        Analytics.CustomEvent("time_completed", new Dictionary<string, object>
        {
            { "acorns_found", timeTaken },
            { "time_elapsed", Time.timeSinceLevelLoad }
        });
    }
}
