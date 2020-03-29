using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public bool keepTiming;

    public float dialogueTime;

    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        keepTiming = false;

        sentences = new Queue<string>();

        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (keepTiming == true)
        {
            dialogueTime += Time.deltaTime;

            //int minutes = Mathf.FloorToInt(dialogueTime / 60); //Divide the guiTime by sixty to get the minutes.
            //int seconds = Mathf.FloorToInt(dialogueTime % 60); //Use the euclidean division for the seconds.
            //int fraction = Mathf.FloorToInt((dialogueTime * 100) % 100);
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);

        animator.SetBool("IsOpen", true);

        keepTiming = true;

        sentences.Clear();

        nameText.text = dialogue.name;

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        Debug.Log("End of Conversation");

        animator.SetBool("IsOpen", false);

        keepTiming = false;
    }
}
