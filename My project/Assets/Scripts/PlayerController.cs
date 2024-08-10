using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Public variables to adjust in the Unity Inspector
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    // Private variables
    private Rigidbody2D rb;
    private bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Handle movement input
        float moveInput = Input.GetAxis("Horizontal"); // Get input from the arrow keys or A/D keys
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Handle jumping
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false; // Player is in the air
        }
    }
    
    // Check if the player is touching the ground
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // Player is back on the ground
        }
    }
}
