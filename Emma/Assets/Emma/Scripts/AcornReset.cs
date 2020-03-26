using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornReset : MonoBehaviour
{
    // Reset the Acorn Counter to 0 once the game is beaten
    void Start()
    {
        GameObject.Find("Emma").GetComponent<Player>().acornOnHand = 0;
    }
}
