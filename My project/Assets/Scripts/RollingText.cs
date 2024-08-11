using System.Collections;
using UnityEngine;
using TMPro;

public class RollingText : MonoBehaviour
{
    public float scrollSpeed = 50f; // Speed of the scrolling
    public float startDelay = 0f; // Delay before starting the scroll
    public float creditsDuration = 240f;

    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        
        // Delay the start of the scrolling
        Invoke("StartScrolling", startDelay);
        StartCoroutine(QuitAfterCredits());
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
    
    private IEnumerator QuitAfterCredits()
    {
        // Wait for the duration of the credits
        yield return new WaitForSeconds(creditsDuration);

        // Quit the game
        QuitGame();
    }

    // Method to quit the game
    void QuitGame()
    {
        Application.Quit();
            // If running in the editor, stop play mode
            #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
            #endif
    }
}

