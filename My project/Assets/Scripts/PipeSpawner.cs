using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float heightOffset = 2;

    private float timer = 0f;
    
    void Update()
    {
        
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        float yOffset = Random.Range(-heightOffset, heightOffset);
        Vector3 spawnPosition = new Vector3(transform.position.x-2.3f, transform.position.y + yOffset, 0);
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }

}
