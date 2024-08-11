using UnityEngine;
using TMPro;

public class RollingText : MonoBehaviour
{
    public float scrollSpeed = 50f; // Speed of the scrolling
    public float startDelay = 0f; // Delay before starting the scroll

    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        
        // Delay the start of the scrolling
        Invoke("StartScrolling", startDelay);
    }

    void Update()
    {
        // Move the text upward
        rectTransform.anchoredPosition += new Vector2(0, scrollSpeed * Time.deltaTime);
        
    }

    private void StartScrolling()
    {
        // Start scrolling after the delay
        enabled = true;
    }
}

