using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf : MonoBehaviour
{
    PlayerDetector playerDetector;

    // Start is called before the first frame update
    void Start()
    {
        playerDetector = transform.Find("PlayerDetector").gameObject.GetComponent<PlayerDetector>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Click leaf to remove it.
    ///FUTURE: Click to move it///
    private void OnMouseDown()
    {
        if (playerDetector.isPlayerInRange)
        {
            Destroy(gameObject);
        }
    }
}
