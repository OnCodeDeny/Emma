using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornLevelPassed : MonoBehaviour
{
    //public Player playerScript;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject thePlayer = GameObject.Find("Emma");
        //Player playerScript = thePlayer.GetComponent<Player>();
        //playerScript.Health -= 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject thePlayer = GameObject.Find("Emma");
        Player playerScript = thePlayer.GetComponent<Player>();
        if (playerScript.acornOnHand >= 3)
        {
            //Debug.Log("Enough Acorns to Beat Level");
        }
    }
}
