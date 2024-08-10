using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatSnacksActivity : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;

    public void EatSnacks()
    {
        _gameManager.timeCounter++;
        _gameManager.levelOfBrainrot++;
    }
}
