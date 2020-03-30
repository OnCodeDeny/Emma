using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public bool isAcornLevelSaved;

    public Vector2 savedBranchPosition;
    public Vector2 savedPlayerPosition;
    public int savedNumberOfAcorns;
    public int savedNumberOfAcornsGenerated;

    
}
