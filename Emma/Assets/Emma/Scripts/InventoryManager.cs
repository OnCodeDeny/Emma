using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class InventoryManager : Singleton<InventoryManager>
{
    /***Uniy Analytics***/
    //Check if the acorn is found for the first time
    bool firstAcornFound = false;
    bool lastAcornFound = false;
    /***Uniy Analytics***/

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    //Represents the number of acorns currenty in the inventory.
    public int acornOnHand;

    private void Update()
    {
        if (acornOnHand > 0 && !firstAcornFound)
        {
            firstAcornFound = true;

            AnalyticsResult result = AnalyticsEvent.Custom("first_acorn_found", new Dictionary<string, object> { { "time_elapsed", Time.timeSinceLevelLoad } });
            Debug.Log("First acorn found event " + result);
        }

        else if (acornOnHand >=6 && !lastAcornFound)
        {
            lastAcornFound = true;

            AnalyticsResult result = AnalyticsEvent.Custom("last_acorn_found", new Dictionary<string, object> { { "time_elapsed", Time.timeSinceLevelLoad } });
            Debug.Log("Last acorn found event " + result);
        }
    }
}
