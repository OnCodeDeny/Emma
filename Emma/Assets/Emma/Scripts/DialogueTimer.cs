using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class DialogueTimer : MonoBehaviour
{
    public DialogueManager dialogueManagerScript;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        // get reference to script
        dialogueManagerScript = GameObject.FindObjectOfType<DialogueManager>();
    }

    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Scene2YouWon")
        {
            ReportDialogueTime();
        }
    }

    void ReportDialogueTime()
    {
        //Debug.Log("Dialogue time recorded as " + dialogueManagerScript.dialogueTime);
        Analytics.CustomEvent("dialogueTime", new Dictionary<string, object>
        {
            { "dialogue open for ", dialogueManagerScript.dialogueTime },
        });
    }
}
