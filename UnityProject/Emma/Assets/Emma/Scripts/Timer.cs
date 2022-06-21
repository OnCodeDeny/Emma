using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float time;

    // Calculates the time counting upwards
    void Update()
    {
            time += Time.deltaTime;

        int minutes = Mathf.FloorToInt(time / 60); //Divide the guiTime by sixty to get the minutes.
        int seconds = Mathf.FloorToInt(time % 60); //Use the euclidean division for the seconds.
        int fraction = Mathf.FloorToInt((time * 100) % 100);
    }
}
