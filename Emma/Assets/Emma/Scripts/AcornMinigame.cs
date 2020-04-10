using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AcornMinigame : MonoBehaviour
{
    //This varable represents the value of each acorn on screen(# of acorns get once clicked an acorn on screen).
    public int amount;
    InventoryManager im;

    private void Start()
    {
        im = GameObject.Find("InventoryManager").GetComponent<InventoryManager>();
    }

    // When the acorn is clicked, it gets added to the amount and is destroyed
    private void OnMouseUpAsButton()
    {
        im.AddAcorn(amount);
        Destroy(gameObject);
    }
}
