﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Represents the number of acorns currenty in the inventory.
    public int acornOnHand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Acorn COUNTER
    public void GetAcorn(int number)
    {
        acornOnHand += number;
    }
}
