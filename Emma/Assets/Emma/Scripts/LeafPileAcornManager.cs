using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafPileAcornManager : MonoBehaviour
{
    public GameObject acornCounter;
    //public int collectedAcorns;
    public int acornsInLeafPileScene;
    public GameObject[] acorns;
    public GameObject leaveButton;
    
    // Start is called before the first frame update
    void Start()
    {
        //collectedAcorns = 0;
        acornCounter = GameObject.Find("Acorn Text");
        acorns = GameObject.FindGameObjectsWithTag("Acorn");
        leaveButton = GameObject.Find("Back Button");
        leaveButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        acorns = GameObject.FindGameObjectsWithTag("Acorn");
        acornsInLeafPileScene = acorns.Length;
        if (acornsInLeafPileScene == 0)
        {
            acornCounter.GetComponent<AcornCounter>().ableToEnterLeafPile = false;
            leaveButton.SetActive(true);
        }        
    }
}
