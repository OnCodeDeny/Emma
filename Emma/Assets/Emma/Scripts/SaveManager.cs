using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//with the jsonTools script, it requires to use Pseudo namespace
using Pseudo;
using System;

public class SaveManager : MonoBehaviour
{
    //All scenes
    public string currentSceneName;
    public List<int> finishedQuest;
    public int acornOnHand;

    //AcornerScene
    public Vector3 playerPosition;
    public Vector3 branchPosition;

    //LeafMinigameScene
    public Vector3[] leavesPositions;
    public bool[] isAcornPickedUp;

    //Time between each save action, in seconds
    public int autoSaveRate;

    private void Start()
    {
        AutoSave(autoSaveRate);
    }

    public void SaveGame()
    {
        currentSceneName = SceneManager.GetActiveScene().name;

        GameData data = new GameData(this);
        JsonTools.SaveSerializedObject(data, Application.dataPath + "/StreamingAssets", "SaveFile");
    }

    IEnumerator AutoSave(int timeBetweenSave)
    {
        SaveGame();
        yield return new WaitForSeconds(timeBetweenSave);
        AutoSave(autoSaveRate);
    }
}
