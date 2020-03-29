using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//with the jsonTools script, it requires to use Pseudo namespace
using Pseudo;
using System;

public class SaveManager : MonoBehaviour
{
    public GameObject player;
    public GameObject branch;
    public GameObject[] leavesInPile;
    public GameObject[] acornsInPile;

    //All scenes
    public string currentSceneName;
    public List<QuestList.Quest> finishedQuest;
    public int acornOnHand;

    //AcornerScene
    public Vector3 playerPosition;
    public Vector3 branchPosition;

    //LeafMinigameScene
    public Vector3[] leavesPositions;
    public Vector3[] acornsPositions;

    //Time between each save action, in seconds
    public int autoSaveRate;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        AutoSave(autoSaveRate);
    }

    public void SaveGame()
    {
        currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == "AcornerScene")
        {
            acornOnHand = player.GetComponent<Player>().acornOnHand;
            branchPosition = branch.transform.position;
            leavesPositions = new Vector3[leavesInPile.Length];
        }

        for (int i = 0; i < leavesPositions.Length; i++)
        {
            leavesPositions[i] = leavesInPile[i].transform.position;
        }
        acornsPositions = new Vector3[acornsInPile.Length];
        for (int i = 0; i < acornsPositions.Length; i++)
        {
            acornsPositions[i] = acornsInPile[i].transform.position;
        }

        GameData data = new GameData(this);
        JsonTools.SaveSerializedObject(data, Application.dataPath + "/StreamingAssets", "SaveFile");
    }

    IEnumerator AutoSave(int timeBetweenSave)
    {
        SaveGame();
        yield return new WaitForSeconds(timeBetweenSave);
        AutoSave(autoSaveRate);
    }
    public void OnQuestUpdate(QuestList.Quest name, bool isCompleted)
    {
        if (isCompleted)
        {
            finishedQuest.Add(name);
        }
    }
}
