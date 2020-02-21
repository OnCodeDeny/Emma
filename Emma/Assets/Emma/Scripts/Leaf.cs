﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf : MonoBehaviour
{
    //Used to check if player is in range.(cannot interact with leaf if out of range)
    ObjectDetector playerDetector;

    // Start is called before the first frame update
    void Start()
    {
        playerDetector = transform.Find("PlayerDetector").gameObject.GetComponent<ObjectDetector>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Click leaf to remove it.
    ///FUTURE: Click to move it///
    private void OnMouseDown()
    {
        if (playerDetector.isObjectInRange)
        {
            Destroy(gameObject);
        }
    }
}
