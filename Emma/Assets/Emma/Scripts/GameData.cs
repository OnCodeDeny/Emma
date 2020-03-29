using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//with the jsonTools script, it requires to use Pseudo namespace
using Pseudo;
using System;

/// <summary>
/// setting serializable to the class allows it to be saved externally
/// </summary>
[Serializable]
public class GameData {

    //All scenes
    public string currentSceneName;
    public List<QuestList.Quest> finishedQuest;
    public int acornOnHand;

    //AcornerScene
    public float[] playerPosition;
    public float[] branchPosition;

    //LeafMinigameScene
    public float[][] leavesPositions;
    public float[][] acornsPositions;

    public GameData(SaveManager sm)
    {
        currentSceneName = sm.currentSceneName;
        finishedQuest = sm.finishedQuest;
        acornOnHand = sm.acornOnHand;

        playerPosition = new float[2];
        playerPosition[0] = sm.playerPosition.x;
        playerPosition[1] = sm.playerPosition.y;
        branchPosition = new float[2];
        branchPosition[0] = sm.branchPosition.x;
        branchPosition[1] = sm.branchPosition.y;

        for (int i = 0; i < sm.leavesPositions.Length; i++)
        {
            leavesPositions[i][0] = sm.leavesPositions[i].x;
            leavesPositions[i][1] = sm.leavesPositions[i].y;
        }
        for (int i = 0; i < sm.acornsPositions.Length; i++)
        {
            acornsPositions[i][0] = sm.acornsPositions[i].x;
            acornsPositions[i][1] = sm.acornsPositions[i].y;
        }
    }
}

//public class TestSave : MonoBehaviour
//{
//    //public GameData myClass = new GameData();

//    // Start is called before the first frame update
//    void Start()
//    {
//        myClass.acornOnHand = 1;


//        ///Unity Editor: <path to project folder>/Assets
//        ///This line calls the save file to the streaming assets folder. This will get created if there is no current folder that exists, and it named "SaveFile"
//        ///feel free to rename SaveFile to whatever you need, as this code can be reused for anything you need to save.
//        ///I would recommend putting this into a SaveManager script where it can be reused on a button press or checkpoint area.
//        JsonTools.SaveSerializedObject(myClass, Application.dataPath + "/StreamingAssets", "SaveFile");

//        ///This line loads the object from memory. Ensure that you have all of this INCLUDING the save file itself in the directory.
//        ///also check to make sure that the type you pass in getcomponent style is the type of class, as it is a generic function to support any custom classes.
//        ///
//        //myClass = JsonTools.DeserializeObject<myClass>(Application.dataPath + "/StreamingAssets" + "/" + "SaveFile");
//    }
//}
