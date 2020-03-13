﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class AnalyticsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ReportSecretFound(0);
        }
    }

    public void ReportSecretFound(int secretID)
    {
        print("event tracked");
        Analytics.CustomEvent("secret_found", new Dictionary<string, object>
    {
        { "secret_id", secretID },
        { "time_elapsed", Time.timeSinceLevelLoad }
    });
    }
}
