using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLeafMinigame : MonoBehaviour
{
    GameManager gameManager;

    //Used to check if player is in range.(cannot interact with leaf pile if out of range)
    ObjectDetector playerDetector;

    public GameObject acornText;

    // for AnalyticsTimeToClickLeaf event
    public bool ClickedLeafLitterBool;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        ClickedLeafLitterBool = false;
        playerDetector = transform.Find("PlayerDetector").gameObject.GetComponent<ObjectDetector>();
        acornText = GameObject.Find("Acorn Text");
    }

    //Click leaf pile to enter minigame
    private void OnMouseDown()
    {
        if (playerDetector.isObjectInRange)
        {
            if (acornText != null)
                //if (acornText.GetComponent<AcornCounter>().ableToEnterLeafPile == true)
                {
                    ClickedLeafLitterBool = true;

                    //Save current scene data
                    gameManager.savedBranchPosition = GameObject.Find("Branch").transform.position;
                    gameManager.savedPlayerPosition = GameObject.Find("Emma").transform.position;
                    gameManager.savedNumberOfAcorns = GameObject.FindGameObjectsWithTag("Acorn").Length;

                    gameManager.isAcornerLevelSaved = true;

                    //Load minigame scene after saving all data in current scene
                    SceneManager.LoadScene("Leaf Minigame");
                }
        }
    }
}
