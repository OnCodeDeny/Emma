using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRestorer : Singleton<SceneRestorer>
{
    GameManager gameManager;

    public GameObject acornPrefab;
    public GameObject acornMinigamePrefab;
    public GameObject leafMinigamePrefab;

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
        else if (SceneManager.GetActiveScene().name == "Leaf Minigame")
        {
            if (gameManager.isAcornMinigameLevelSaved)
            {
                foreach (GameObject acorn in GameObject.FindGameObjectsWithTag("Acorn"))
                {
                    Destroy(acorn);
                }
                foreach (GameObject leaf in GameObject.FindGameObjectsWithTag("Leaf Pile Leaf"))
                {
                    Destroy(leaf);
                }

                for (int i = 0; i < gameManager.savedAcornsPositions.Length; i++)
                {
                    GameObject acorn = Instantiate(acornMinigamePrefab, gameManager.savedAcornsPositions[i], gameManager.savedAcornsRotations[i]);
                    acorn.transform.localScale = gameManager.savedAcornsScales[i];
                }
                for (int i = 0; i < gameManager.savedLeavesPositions.Length; i++)
                {
                    GameObject leaf = Instantiate(leafMinigamePrefab, gameManager.savedLeavesPositions[i], gameManager.savedLeavesRotations[i]);
                    leaf.transform.localScale = gameManager.savedLeavesScales[i];
                    leaf.GetComponent<SpriteRenderer>().color = gameManager.savedLeavesColors[i];
                }
            }
        }
    }
}
