﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Click leaf to remove it.
    ///FUTURE: Click to move it///
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
