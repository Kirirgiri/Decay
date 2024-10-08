using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    private DialogueDisplayer _dialogueDisplayer;

    public DialogueObject[] _dialogueObjects;


    // Start is called before the first frame update
    void Start()
    {
        _dialogueDisplayer = GetComponent<DialogueDisplayer>();
        _dialogueDisplayer.DisplayDialogue(_dialogueObjects[0]);
    }

    public void SwitchDialogue(int dialogueIndex)
    {
        if(dialogueIndex<_dialogueObjects.Length && !_dialogueDisplayer.dialogueBox.activeSelf)
        {
            _dialogueDisplayer.DisplayDialogue(_dialogueObjects[dialogueIndex]);
        }
    }
}
