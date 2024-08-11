using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed = 2f;
    [SerializeField] private GameObject minigame;
    private bool isItOver;

    private void Start()
    {
        isItOver = minigame.GetComponent<PlayerController>().gameOver;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Destroy pipes after they move off-screen
        if (transform.position.x < -2f || isItOver)
        {
            Destroy(gameObject);
        }
    }
}

