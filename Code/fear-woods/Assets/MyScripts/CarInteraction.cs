using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInteraction : MonoBehaviour
{
   private CollectionParts collectionManager;

    private void Start()
    {
        collectionManager = FindObjectOfType<CollectionParts>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && collectionManager.AllPartsCollected())
        {
            Debug.Log("Player has all parts and interacted with the car. Game over!");
        }
    }
}
