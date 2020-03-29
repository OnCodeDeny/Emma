using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class AnalyticsTimeToHitTree : MonoBehaviour
{
    public GameObject branch;
    private void Update()
    {
        if (branch.GetComponent<Branch>().treeHit)
        {
            ReportTimeTaken(GameObject.Find("Time Tracker").GetComponent<Timer>().time);
        }
    }

    // Report the analytics when the player hits the tree with branch
    public void ReportTimeTaken(float timeTakenID)
    {
        Analytics.CustomEvent("time_till_tree_hit", new Dictionary<string, object>
        {
            { "tree_hit_id", timeTakenID },
            { "time_elapsed", Time.timeSinceLevelLoad }
        });
    }
}
