using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialMessage : MonoBehaviour
{
    public GameObject tutorialMessage;

    void Start()
    {
        Time.timeScale = 0f;
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            tutorialMessage.SetActive(false);
            Time.timeScale = 1f; 
            this.enabled = false;
        }
        
    }
}
