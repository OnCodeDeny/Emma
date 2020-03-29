using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTimer : MonoBehaviour
{
    public bool keepTiming;

    public float dialogueTime;

    void Update()
    {
        if(keepTiming == true)
        {
            dialogueTime += Time.deltaTime;
        }
    }

    void OnBecameVisible()
    {
        Debug.Log("Text box is visible");
        keepTiming = true;
    }

    void OnBecameInvisible()
    {
        Debug.Log("Text box is invisible");
        keepTiming = false;
    }
}
