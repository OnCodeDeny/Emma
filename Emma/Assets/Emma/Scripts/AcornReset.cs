using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornReset : MonoBehaviour
{
    // Destroy the specified objects when the game reaches the scene with this script attached
    void Start()
    {
        GameObject.Find("Emma").GetComponent<Player>().acornOnHand = 0;
    }
}
