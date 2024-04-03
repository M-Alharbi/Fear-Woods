using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudioPlay : MonoBehaviour
{
    public AudioSource audioSource; 
    private float minDelay = 120f; 
    private float maxDelay = 250f; 

    private float nextPlayTime;

    void Start()
    {
        NextPlay();
    }

    void Update()
    {
        if (Time.time >= nextPlayTime)
        {
            audioSource.Play();
            NextPlay();
        }
    }

    void NextPlay()
    {
        nextPlayTime = Time.time + Random.Range(minDelay, maxDelay);
    }
}
