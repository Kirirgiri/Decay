using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int timeCounter;
    private int oldCounter = 0;
    public TMP_Text uiText;
    public int levelOfBrainrot = 0;

    private float startHours = 9f;
    private float startMinutes = 30f;
    private float endHours = 24f;
    private float endMinutes = 45f;
    private float elapsedTime = 0f;
    private float progressDuration = 0.1f; // Example duration for change

    // Start is called before the first frame update
    void Start()
    {
        UpdateTimeDisplay(startHours, startMinutes);
    }

    private void Update()
    {
        if (timeCounter > oldCounter)
        {
            elapsedTime += progressDuration;
            
            float progress = Mathf.Clamp(elapsedTime, 0f, 1f);
            float hours = Mathf.Lerp(startHours, endHours, progress);
            float minutes = Mathf.Lerp(startMinutes, endMinutes, progress);

            UpdateTimeDisplay(hours, minutes);
            oldCounter = timeCounter;
        }

        if (timeCounter > 10)
        {
            AnalyzeBrainrot();
        }
    }
    
    void UpdateTimeDisplay(float hours, float minutes)
    {
        int displayHours = Mathf.FloorToInt(hours);
        int displayMinutes = Mathf.FloorToInt(minutes);

        uiText.text = $"{displayHours:D2}:{displayMinutes:D2}";  // Format as HH:mm
    }

    private void AnalyzeBrainrot()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
