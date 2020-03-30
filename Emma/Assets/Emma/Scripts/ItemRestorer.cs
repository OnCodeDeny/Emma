using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemRestorer : MonoBehaviour
{
    GameManager gameManager;

    public GameObject acornPrefab;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        if (SceneManager.GetActiveScene().name == "AcornerScene")
        {
            if (gameManager.isAcornLevelSaved)
            {
                for (int i = 0; i < gameManager.savedNumberOfAcorns; i++)
                {
                    Instantiate(acornPrefab, new Vector3(1 + i * Random.Range(0.5f, 3f), -3, 0), Quaternion.identity);
                }
            }
        }
    }

}
