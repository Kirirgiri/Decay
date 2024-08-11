using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighter : MonoBehaviour
{
    public Sprite originalSprite; // The original sprite of the object
    public Sprite hoverSprite;    // The sprite to change to when hovering

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Get the SpriteRenderer component attached to this object
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Set the original sprite if not already set in the Inspector
        if (originalSprite == null)
        {
            originalSprite = spriteRenderer.sprite;
        }
    }

    void OnMouseEnter()
    {
        // Change the sprite to the hover sprite when the mouse enters the object's collider
        spriteRenderer.sprite = hoverSprite;
    }

    void OnMouseExit()
    {
        // Change the sprite back to the original sprite when the mouse exits the object's collider
        spriteRenderer.sprite = originalSprite;
    }
}
