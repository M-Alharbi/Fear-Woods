using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPointsLocation : MonoBehaviour
{
    public GameObject[] parts;
    public Transform[] spawnPoints;
    
    void Start()
    {
        SpawnParts();
    }

    void SpawnParts()
    {
        List<Transform> availableSpawnPoints = new List<Transform>(spawnPoints);

        foreach (GameObject part in parts)
        {
          

            if(availableSpawnPoints.Count == 0)
            {
                Debug.Log("No spawn points available");
                break;
            }
            
            int randomIndex = Random.Range(0, availableSpawnPoints.Count);
            
            Transform spawnPoint = availableSpawnPoints[randomIndex];
           
            Instantiate(part, spawnPoint.position, spawnPoint.rotation);
            
            Debug.Log("Spawning part at: " + spawnPoint.position); 

            availableSpawnPoints.RemoveAt(randomIndex);
        }
    }


}
