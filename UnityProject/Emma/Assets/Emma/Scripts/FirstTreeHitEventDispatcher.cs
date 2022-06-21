using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class FirstTreeHitEventDispatcher : MonoBehaviour
{
    /***Uniy Analytics***/
    //Check if the tree is hit for the first time
    bool treeHit = false;
    /***Uniy Analytics***/

    public void DispatchFirstTreeHitEvent()
    {
        if (!treeHit)
        {
            treeHit = true;

            //Parameter : time_elapsed, represents the time spent in the level before the player fisrt time hit the tree with branch
            AnalyticsResult result = AnalyticsEvent.Custom("Tree_Hit_with_Branch", new Dictionary<string, object> { { "time_elapsed", Time.timeSinceLevelLoad } });
            //Debug.Log("First tree hit event " + result);
        }
    }
}
