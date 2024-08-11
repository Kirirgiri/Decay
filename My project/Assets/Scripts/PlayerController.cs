using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerController : MonoBehaviour
{
    // Public variables to adjust in the Unity Inspector
    public float moveSpeed = 5f;
    public float jumpForce = 1f;

    // Private variables
    private Rigidbody2D rb;

    [SerializeField] private GameObject btn;
    [SerializeField] private TMP_Text score;
    public bool gameOver = false;
    private AudioSource jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        jumpSound = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Handle movement input
        float moveInput = Input.GetAxis("Horizontal"); // Get input from the arrow keys or A/D keys
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Handle jumping
        if (Input.GetButtonDown("Jump"))
        {
            jumpSound.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
    
    // Check if the player is touching the ground
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            gameOver = true;
            btn.GetComponent<Minigame>().EndFlappy();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("scoreAdd"))
        {
            var highscore = btn.GetComponent<Minigame>().highScore + 1;
            score.SetText("Score:"+highscore);
        }
    }
}
