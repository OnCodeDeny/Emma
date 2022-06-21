using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn : MonoBehaviour
{
    //This varable represents the value of each acorn on screen(# of acorns get once clicked an acorn on screen).
    public int amount;

    InventoryManager im;
    ObjectDetector playerDetector;

    // Start is called before the first frame update
    void Start()
    {
        //Use player detector to detect player distance to this object
        playerDetector = transform.Find("PlayerDetector").gameObject.GetComponent<ObjectDetector>();

        im = GameObject.Find("InventoryManager").GetComponent<InventoryManager>();
    }

    private void OnMouseUpAsButton()
    {
        //If player is in range, acorn is able to be collected.
        if (playerDetector.isObjectInRange)
        {
            im.AddAcorn(amount);
            Destroy(gameObject);
        }
    }
}
