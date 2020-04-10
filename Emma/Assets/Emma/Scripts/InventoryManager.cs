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

    //Represents the number of acorns currenty in the inventory.
    public int acornOnHand;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (acornOnHand > 0 && !firstAcornFound)
        {
            firstAcornFound = true;

            //Parameter : time_elapsed, represents the time spent in the level before the player picks up the first acorn
            AnalyticsResult result = AnalyticsEvent.Custom("first_acorn_found", new Dictionary<string, object> { { "time_elapsed", Time.timeSinceLevelLoad } });
            //Debug.Log("First acorn found event " + result);
        }

        else if (acornOnHand >=6 && !lastAcornFound)
        {
            lastAcornFound = true;

            //Parameter : time_elapsed, represents the time spent in the level before the player picks up the last acorn
            AnalyticsResult result = AnalyticsEvent.Custom("last_acorn_found", new Dictionary<string, object> { { "time_elapsed", Time.timeSinceLevelLoad } });
            //Debug.Log("Last acorn found event " + result);
        }
    }

    public void Reset()
    {
        acornOnHand = 0;
    }
}
