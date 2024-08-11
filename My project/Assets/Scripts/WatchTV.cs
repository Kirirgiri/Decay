using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchTV : MonoBehaviour
{
    public GameObject tv;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private MainManager _mainManager;
    [SerializeField] private DialogueDisplayer _dialogueManager;
    private void OnMouseDown()
    {
        tv.SetActive(true);
        StartCoroutine(PlayTV());
        _mainManager.levelOfBedrot++;
    }

    private IEnumerator PlayTV()
    {
        yield return new WaitForSeconds(7.5f);
        tv.SetActive(false);
        _gameManager.timeCounter += 2;
        yield return null;
    }
    
}
