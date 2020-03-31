using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Load the scene indicated by its Index Number in the scene
    public void LoadByIndex(int sceneIndex)
    {
        if (sceneIndex == 1 && SceneManager.GetActiveScene().name == "Leaf Minigame")
        {
            GameObject[] acorns = GameObject.FindGameObjectsWithTag("Acorn");
            gameManager.savedAcornsPositions = new Vector2[acorns.Length];
            gameManager.savedAcornsRotations = new Quaternion[acorns.Length];
            gameManager.savedAcornsScales = new Vector3[acorns.Length];
            for (int i = 0; i < acorns.Length; i++)
            {
                gameManager.savedAcornsPositions[i] = acorns[i].transform.position;
                gameManager.savedAcornsRotations[i] = acorns[i].transform.rotation;
                gameManager.savedAcornsScales[i] = acorns[i].transform.localScale;
            }

            GameObject[] leaves = GameObject.FindGameObjectsWithTag("Leaf Pile Leaf");
            gameManager.savedLeavesPositions = new Vector2[leaves.Length];
            gameManager.savedLeavesRotations = new Quaternion[leaves.Length];
            gameManager.savedLeavesScales = new Vector3[leaves.Length];
            gameManager.savedLeavesColors = new Color[leaves.Length];
            for (int i = 0; i < leaves.Length; i++)
            {
                gameManager.savedLeavesPositions[i] = leaves[i].transform.position;
                gameManager.savedLeavesRotations[i] = leaves[i].transform.rotation;
                gameManager.savedLeavesScales[i] = leaves[i].transform.localScale;
                gameManager.savedLeavesColors[i] = leaves[i].GetComponent<SpriteRenderer>().color;
            }

            gameManager.isAcornMinigameLevelSaved = true;
        }
        SceneManager.LoadScene(sceneIndex);
    }
}
