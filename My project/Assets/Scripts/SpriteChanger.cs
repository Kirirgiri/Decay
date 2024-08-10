using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour
{
    public Sprite newSprite;            // The new sprite you want to switch to
    private Image uiImage;              // Reference to the UI Image component

    void Start()
    {
        // Get the Image component attached to this GameObject
        uiImage = GetComponent<Image>();
    }

    public void ChangeSprite()
    {
        if (uiImage != null)
        {
            uiImage.sprite = newSprite;
        }
    }
}
