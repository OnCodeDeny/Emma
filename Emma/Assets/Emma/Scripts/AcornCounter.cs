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


    // Counts upwards when an acorn is collected
    void Update()
    {       
        amount = player.acornOnHand;
        textComponent.text = "Acorns: " + amount;

        // check amount of acorns collected, if equal to six, Load scene 2, then reset the amount to 0
        // so if you restart the scene, you start over with 0 acorns
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
