using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornReset : MonoBehaviour
{
    InventoryManager im;
    // Reset the Acorn Counter to 0 once the game is beaten
    void Start()
    {
        im = GameObject.Find("InventoryManager").GetComponent<InventoryManager>();
        im.acornOnHand = 0;
    }
}
