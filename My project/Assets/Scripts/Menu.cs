using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject menuPanel;  // The main menu panel
    public Button startButton;    // Button to start the game
    public Button quitButton;     // Button to quit the game
    public Button settingsButton; // Optional: Button to open settings
    public Slider volume;
    public Button back;
    void Start()
    {
        // Ensure the menu is active when the game starts
        menuPanel.SetActive(true);

        // Assign button click listeners
        startButton.onClick.AddListener(StartGame);
        quitButton.onClick.AddListener(QuitGame);

        // Optional: Add a listener for the settings button
        if (settingsButton != null)
        {
            settingsButton.onClick.AddListener(OpenSettings);
        }
    }

    public void StartGame()
    {
        // Load the next scene (you may need to set up your scenes in the Build Settings)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Function to quit the game
    public void QuitGame()
    {
        // Quit the application
        Application.Quit();
        
        // If running in the Unity editor, stop playing
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    public void OpenSettings()
    {
        
    }
}
