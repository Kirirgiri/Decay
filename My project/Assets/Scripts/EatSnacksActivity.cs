using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatSnacksActivity : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private MainManager _mainManager;
    [SerializeField] private DialogueDisplayer _dialogueManager;
    [SerializeField] private GameObject nachos;

    private AudioSource crunch;
    
    private void Start()
    {
        crunch = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        _mainManager.levelOfBedrot++;
        _dialogueManager.GetComponent<DialogueManager>().SwitchDialogue(2);
        EatNachos();
    }

    private IEnumerator EatingNachos(GameObject nachos)
    {
        nachos.SetActive(true);
        crunch.Play();
        yield return new WaitForSeconds(6f);
        nachos.SetActive(false);
        _gameManager.timeCounter+=2;
    }

    private void EatNachos()
    {
        StartCoroutine(EatingNachos(nachos));
    }
}
