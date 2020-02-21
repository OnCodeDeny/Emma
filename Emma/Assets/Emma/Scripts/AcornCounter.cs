using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AcornCounter : MonoBehaviour
{
    //Set Variables
    public static int amount;
    public Text textComponent;
    public Player player;

    // Get the distance from the player to the object
    void Start()
    {
    }

    // Counts upwards when an acorn is collected
    void Update()
    {
        amount = player.acornOnHand;
        textComponent.text = "Acorns: " + amount;

        if (amount == 6)
        {
            LoadByIndex(2);
            amount = 0;
        }
    }

    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }



}
