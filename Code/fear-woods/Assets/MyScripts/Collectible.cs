using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private CollectionParts collectionManager; 

    private CollectionList collectionList;

    public int partIndex; 

    private void Start()
    {
        
        collectionManager = FindObjectOfType<CollectionParts>();

        collectionList = FindObjectOfType<CollectionList>();
    }

    public void Collect()
    {
        collectionList.CollectPart(partIndex);
        collectionManager.CollectPart();
        Debug.Log("Player collected an item");
        Destroy(gameObject); 
    }
}
