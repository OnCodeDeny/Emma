using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        //Find if this scene has previously saved data
        if (gameManager.isAcornerLevelSaved)
        {
            //Retrieve previously saved player position
            transform.position = gameManager.savedPlayerPosition;
        }
    }

}
