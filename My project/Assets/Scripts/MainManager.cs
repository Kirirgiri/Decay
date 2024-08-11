using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MainManager : MonoBehaviour
{
    public static MainManager instance;
    [FormerlySerializedAs("levelOfBrainrot")] public int levelOfBedrot = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        if (levelOfBedrot < 5)
        {
            Debug.Log("Congrats, you actually feel refreshed! Groggy, but refreshed");
        }else if (levelOfBedrot < 7)
        {
            Debug.Log("You might need to touch some grass");
        }
        else
        {
            Debug.Log("Touch some grass");
        }
    }
    
}
