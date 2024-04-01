using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionParts : MonoBehaviour
{
    private int collectedParts = 0;

    public int totalPartsNeeded;
    
    public void CollectPart()
    {
        collectedParts++;
        Debug.Log("Player collected a part. Total parts: " + collectedParts);

        if (collectedParts >= totalPartsNeeded)
        {
            Debug.Log("Player collected all parts");
        }
    }

    public bool AllPartsCollected()
    {
        return collectedParts >= totalPartsNeeded;
    }

}
