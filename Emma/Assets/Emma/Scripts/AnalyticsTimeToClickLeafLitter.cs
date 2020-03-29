using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class AnalyticsTimeToClickLeafLitter : MonoBehaviour
{    
    public EnterLeafMinigame EnterAcornMinigameScript;
    public bool ClickedLeafLitter;

    // Start is called before the first frame update
    void Start()
    {
        // get reference to script
        EnterAcornMinigameScript = GameObject.FindObjectOfType<EnterLeafMinigame>();              
    }

    // Update is called once per frame
    void Update()
    {
        // Find the boolean in the script EnterLeafMinigame on the gameobject Leaf Pile
        ClickedLeafLitter = GameObject.Find("Leaf Pile").GetComponent<EnterLeafMinigame>().ClickedLeafLitterBool;
        //Debug.Log("In AnalyticsTimeToClickLeafLitter bool ClickedLeafLitter= " + ClickedLeafLitter);

        // if that boolean is true, call the function ReportLeafLitterClicked
        if (ClickedLeafLitter == true)
        {
            //Debug.Log("ClickedLeafLitter in AnalyticsTimeToClickLeafLitter");
            ReportLeafLitterClicked(0);
        }
    }

    public void ReportLeafLitterClicked(int leafLitterClickedID)
    {
        // track the event for analytics, which you can find through "go to dashboard" in Services in Unity
        print("ClickLeafLitterEvent tracked");
        Analytics.CustomEvent("LeafLitterEvent_Clicked", new Dictionary<string, object>
        {
            { "leaflitterclick_id", leafLitterClickedID },
            { "time_elapsed", Time.timeSinceLevelLoad }
        });
    }
}