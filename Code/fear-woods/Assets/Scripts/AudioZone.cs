using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioZone : MonoBehaviour
{
   private AudioSource audioSource;

   private  void Start()
    {
       
        audioSource = GetComponent<AudioSource>();
    }

   
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player") && !audioSource.isPlaying)
        {
           
            
            audioSource.Play();
            
        }
    }
}
