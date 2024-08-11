using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private GameObject[] activities;

    // Update is called once per frame
    void Update()
    {
        if (dialogueBox.activeSelf == true)
        {
            for (int i = 0; i < activities.Length; i++)
            {
                activities[i].GetComponent<BoxCollider2D>().enabled = false;
            }
        }else if (dialogueBox.activeSelf == false)
        {
            for (int i = 0; i < activities.Length; i++)
            {
                activities[i].GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }
}
