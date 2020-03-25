using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLeafMinigame : MonoBehaviour
{
    //Used to check if player is in range.(cannot interact with leaf pile if out of range)
    ObjectDetector playerDetector;

    // Start is called before the first frame update
    void Start()
    {
        playerDetector = transform.Find("PlayerDetector").gameObject.GetComponent<ObjectDetector>();
    }

    //Click leaf pile to enter minigame
    private void OnMouseDown()
    {
        if (playerDetector.isObjectInRange)
        {
            SceneManager.LoadScene("Leaf Minigame");
        }
    }
}
