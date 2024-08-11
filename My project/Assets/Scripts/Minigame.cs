using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame : MonoBehaviour
{
    public GameObject minigame;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private MainManager _mainManager;
    [SerializeField] private GameObject[] buttons;
    public void PlayFlappy()
    {
        minigame.SetActive(true);
        _mainManager.levelOfBedrot++;
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].SetActive(false);
        }
        
    }

    public void EndFlappy()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].SetActive(true);
        }

        _gameManager.timeCounter++;
        minigame.SetActive(false);
    }
    
}
