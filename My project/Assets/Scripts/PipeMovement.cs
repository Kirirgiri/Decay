using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Destroy pipes after they move off-screen
        if (transform.position.x < -2f)
        {
            Destroy(gameObject);
        }
    }
}

