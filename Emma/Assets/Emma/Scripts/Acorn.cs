using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn : MonoBehaviour
{
    //This varable represents the value of each acorn on screen(# of acorns get once clicked an acorn on screen).
    public int amount;

    GameObject player;
    ObjectDetector playerDetector;

    // Start is called before the first frame update
    void Start()
    {
        //Use player detector to detect player distance to this object
        playerDetector = transform.Find("PlayerDetector").gameObject.GetComponent<ObjectDetector>();
        player = GameObject.Find("Emma");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        //If player is in range, acorn is able to be collected.
        if (playerDetector.isObjectInRange)
        {
            player.GetComponent<Player>().GetAcorn(amount);
            Destroy(gameObject);
        }
    }
}
