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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
