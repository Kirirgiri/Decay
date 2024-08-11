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
    [SerializeField] private GameObject player;

    private AudioSource click;
    [SerializeField] private AudioSource bg;
    
    private void Start()
    {
        click = GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        click.Play();
        minigame.SetActive(true);
        highScore = 0;
        scoreVisibility.SetActive(true);
        _mainManager.levelOfBedrot++;
        bg.Pause();
    }

    public void EndFlappy()
    {
        scoreVisibility.SetActive(false);
        _gameManager.timeCounter+=2;
        player.GetComponent<PlayerController>().gameOver = false;
        _dialogueManager.GetComponent<DialogueManager>().SwitchDialogue(3);
        bg.Play();
        minigame.SetActive(false);
    }
    
}
