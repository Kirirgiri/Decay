using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatSnacksActivity : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private MainManager _mainManager;
    [SerializeField] private GameObject nachos;

    public void EatSnacks()
    {
        _mainManager.levelOfBedrot++;
        EatNachos();
    }

    private IEnumerator EatingNachos(GameObject nachos)
    {
        nachos.SetActive(true);
        yield return new WaitForSeconds(6f);
        nachos.SetActive(false);
        _gameManager.timeCounter++;
    }

    private void EatNachos()
    {
        StartCoroutine(EatingNachos(nachos));
    }
}
