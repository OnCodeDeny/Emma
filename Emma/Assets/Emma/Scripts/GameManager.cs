using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }


    public bool isAcornLevelSaved = false;
    public Vector2 savedBranchPosition;
    public Vector2 savedPlayerPosition;
    public int savedNumberOfAcorns;
    public int savedNumberOfAcornsGenerated;


    public bool isAcornMinigameLevelSaved = false;
    public Vector2[] savedLeavesPositions;
    public Quaternion[] savedLeavesRotations;
    public Vector3[] savedLeavesScales;
    public Color[] savedLeavesColors;

    public Vector2[] savedAcornsPositions;
    public Quaternion[] savedAcornsRotations;
    public Vector3[] savedAcornsScales;

}
