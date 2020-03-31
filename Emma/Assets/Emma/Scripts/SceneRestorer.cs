using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRestorer : Singleton<SceneRestorer>
{
    GameManager gameManager;

    //Prefabs needed to restore scenes
    public GameObject acornPrefab;
    public GameObject acornMinigamePrefab;
    public GameObject leafMinigamePrefab;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        //Check current scene name, restore scene according to its name
        if (SceneManager.GetActiveScene().name == "AcornerScene")
        {
            //Check if there was a previous section with this scene, no need to restore when first time enter the scene
            if (gameManager.isAcornerLevelSaved)
            {
                //Load saved data to the scene
                for (int i = 0; i < gameManager.savedNumberOfAcorns; i++)
                {
                    Instantiate(acornPrefab, new Vector3(1 + i * Random.Range(0.5f, 3f), -3, 0), Quaternion.identity);
                }
            }
        }
        //Check current scene name, restore scene according to its name
        else if (SceneManager.GetActiveScene().name == "Leaf Minigame")
        {
            //Check if there was a previous section with this scene, no need to restore when first time enter the scene
            if (gameManager.isLeafMinigameLevelSaved)
            {
                //Load saved data to the scene
                //Destroy & rebuild
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
