
using UnityEngine;

[CreateAssetMenu(menuName = "Dialogue/DialogueObject")]
public class DialogueObject : ScriptableObject
{
    //order in the array is the order of the dialogue
    public DialogueLine[] dialogueLines;
}
