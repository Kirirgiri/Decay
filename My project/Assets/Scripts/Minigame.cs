using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame : MonoBehaviour
{
    public GameObject minigame;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private MainManager _mainManager;
    [SerializeField] private DialogueDisplayer _dialogueManager;
    [SerializeField] private GameObject scoreVisibility;
    public int highScore;
    private void OnMouseDown()
    {
        minigame.SetActive(true);
        highScore = 0;
        scoreVisibility.SetActive(true);
        _mainManager.levelOfBedrot++;
    }

    public void EndFlappy()
    {
        scoreVisibility.SetActive(false);
        _gameManager.timeCounter+=2;
        _dialogueManager.GetComponent<DialogueManager>().SwitchDialogue(3);
        minigame.SetActive(false);
    }
    
}
