using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene("Win");
        }
    }
}
