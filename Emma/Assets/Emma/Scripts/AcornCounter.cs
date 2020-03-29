using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class AcornCounter : MonoBehaviour
{
    //Set Variables
    public static int amount;
    public Text textComponent;
    public Player player;
    public GameObject rootCanvas;
    private static GameObject instance;
    public bool ableToEnterLeafPile;

    // bool for total clicks event in "ClicksToFinishGame" script
    public bool acornCounterLevelDoneBool;

    void Start()
    {
        ableToEnterLeafPile = true;
        acornCounterLevelDoneBool = false;

        // Keep the Canvas in between scenes
        DontDestroyOnLoad(rootCanvas);

        // Don't spawn a 2nd canvas if the first one is still there when loading a new scene
        if (instance == null)
        {
            instance = rootCanvas;
        }
        else
        {
            Destroy(rootCanvas);
        }
    }

    // Counts upwards when an acorn is collected
    void Update()
    {       
        amount = player.acornOnHand;
        textComponent.text = "Acorns: " + amount;

        // check amount of acorns collected, if equal to six, Load scene 2, then reset the amount to 0
        // so if you restart the scene, you start over with 0 acorns
        if (amount == 6)
        {
            acornCounterLevelDoneBool = true;
            LoadByIndex(2);
            amount = 0;
        }
    }

    // So can load a scene if correct amount of acorns
    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
