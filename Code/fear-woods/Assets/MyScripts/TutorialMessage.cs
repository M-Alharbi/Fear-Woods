using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialMessage : MonoBehaviour
{
    public GameObject tutorialMessage;


    void Update()
    {
        if (Input.anyKeyDown)
        {
            tutorialMessage.SetActive(false);
            this.enabled = false;
        }
        
    }
}
