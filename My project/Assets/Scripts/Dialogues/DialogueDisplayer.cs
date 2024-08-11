using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueDisplayer : MonoBehaviour
{
    public static DialogueDisplayer instance;
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TMP_Text dialogueText;
    public float typingSpeed = 0.05f; // Time in seconds between each letter

    private bool skipLineTriggered = false;
    

    private IEnumerator MoveThroughDialogue(DialogueObject dialogueObject)
    {
            for(int i = 0; i < dialogueObject.dialogueLines.Length; i++)
            {
                if (!skipLineTriggered)
                {
                    dialogueText.text = dialogueObject.dialogueLines[i].dialogue;
            
                    StartCoroutine(TypeText(dialogueText.text));
                    //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
                    yield return new WaitForSeconds(3f);
                    //The following line of codes make the coroutine wait for a frame so as the next WaitUntil is not skipped
                    yield return null;
                }
            }
        dialogueBox.SetActive(false);
    }
    private IEnumerator TypeText(string dialogue)
    {
        dialogueText.text = ""; // Clear the text at the start
        foreach (char letter in dialogue.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed); // Wait for typingSpeed seconds before adding the next letter
        }
    }
    public void DisplayDialogue(DialogueObject dialogueObject)
    {
        dialogueBox.SetActive(true);
        StartCoroutine(MoveThroughDialogue(dialogueObject));
    }
    
}