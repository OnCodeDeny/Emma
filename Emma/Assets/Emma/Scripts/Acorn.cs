using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn : MonoBehaviour
{
    public GameObject player;
    public int amount;
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

    private void OnMouseUpAsButton()
    {
        if (playerDetector.isPlayerInRange)
        {
            player.GetComponent<Player>().GetAcorn(amount);
            Destroy(gameObject);
        }
    }
}
