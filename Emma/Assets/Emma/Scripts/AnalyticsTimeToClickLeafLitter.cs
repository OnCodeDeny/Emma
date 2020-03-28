using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class AnalyticsTimeToClickLeafLitter : MonoBehaviour
{
    //public static AcornMinigame AcornMinigameScript;
    //public GameObject leafPile; 
    public EnterLeafMinigame EnterAcornMinigameScript;
    public bool ClickedLeafLitter;

    //GameObject.Find("nameOfObjectYourScriptIsOn").GetComponent<move>().speed

    //// In script other than move and also on different Game Object
    //move _move = FindObjectOfType<move>();
    //_move.speed = 10;

//    public ScriptA script;

//    void Start()
//    {
//        script = GameObject.FindObjectOfType<ScriptA>();
//    }

//    void Update()
//    {
//        if (script.variable...)
//}


    // Start is called before the first frame update
    void Start()
    {
        //EnterAcornMinigameScript = leafPile.GetComponent<EnterLeafMinigame>();
        EnterAcornMinigameScript = GameObject.FindObjectOfType<EnterLeafMinigame>();
      
        
    }

    // Update is called once per frame
    void Update()
    {

        //desired: when click leaf litter, eg if bool == true
        // maybe put in Tyler's script, and access here:
        // if (EnterLeafMinigame.ClickedLeafLitterBool == true)

        //GameObject.Find("nameOfObjectYourScriptIsOn").GetComponent<move>().speed
        ClickedLeafLitter = GameObject.Find("Leaf Pile").GetComponent<EnterLeafMinigame>().ClickedLeafLitterBool;
        Debug.Log("In AnalyticsTimeToClickLeafLitter bool ClickedLeafLitter= " + ClickedLeafLitter);
        if (ClickedLeafLitter == true)
        {
            Debug.Log("ClickedLeafLitter in AnalyticsTimeToClickLeafLitter");
            ReportLeafLitterClicked(0);
        }

        //test
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    ReportLeafLitterClicked(0);
        //}
    }

    public void ReportLeafLitterClicked(int leafLitterClickedID)
    {
        print("ClickLeafLitterEvent tracked");
        Analytics.CustomEvent("LeafLitterEvent_Clicked", new Dictionary<string, object>
        {
            { "secret_id", leafLitterClickedID },
            { "time_elapsed", Time.timeSinceLevelLoad }
        });
    }
}