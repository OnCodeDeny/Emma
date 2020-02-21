using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn : MonoBehaviour
{
    public int amount;
    GameObject player;
    ObjectDetector playerDetector;

    // Start is called before the first frame update
    void Start()
    {
        playerDetector = transform.Find("PlayerDetector").gameObject.GetComponent<ObjectDetector>();
        player = GameObject.Find("Emma");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        if (playerDetector.isObjectInRange)
        {
            player.GetComponent<Player>().GetAcorn(amount);
            Destroy(gameObject);
        }
    }
}
