using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    //Track how many acorns have dropped from tree
    public int acornGenerated;

    /// <summary>
    /// Data need to save for Acorner level
    /// </summary>
    public bool isAcornerLevelSaved = false;
    public Vector2 savedBranchPosition;
    public Vector2 savedPlayerPosition;
    public int savedNumberOfAcorns;

    /// <summary>
    /// Data need to save for Leaf Minigame level
    /// </summary>
    public bool isLeafMinigameLevelSaved = false;
    public Vector2[] savedLeavesPositions;
    public Quaternion[] savedLeavesRotations;
    public Vector3[] savedLeavesScales;
    public Color[] savedLeavesColors;
    public Vector2[] savedAcornsPositions;
    public Quaternion[] savedAcornsRotations;
    public Vector3[] savedAcornsScales;

}
