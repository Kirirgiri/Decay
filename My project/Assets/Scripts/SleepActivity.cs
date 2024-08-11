using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SleepActivity : MonoBehaviour
{
    [SerializeField] private Image darkness;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private DialogueDisplayer _dialogueManager;
    
    public float fadeDuration = 2f;
    private bool sleepActive = false;
    
    public void OnMouseDown()
    {
        StartCoroutine(Sleep());
        _dialogueManager.GetComponent<DialogueManager>().SwitchDialogue(1);
    }

    IEnumerator Sleep()
    {
        if (!sleepActive)
        {
            // Fade in
            yield return StartCoroutine(FadeTo(1f, fadeDuration));
        
            _gameManager.timeCounter++;
        
            // Fade out
            yield return StartCoroutine(FadeTo(0f, fadeDuration));
        }
    }

    IEnumerator FadeTo(float targetAlpha, float duration)
    {
        Color originalColor = darkness.color;
        float startAlpha = originalColor.a;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / duration);
            darkness.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            yield return null; // Wait until the next frame
        }

        // Ensure the image reaches the target alpha at the end
        darkness.color = new Color(originalColor.r, originalColor.g, originalColor.b, targetAlpha);
        yield return new WaitForSeconds(2f);
    }
}
