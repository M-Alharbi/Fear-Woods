using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.AI;

public class MonsterController : MonoBehaviour
{
    public Transform player; // Reference to fps
    private NavMeshAgent navMeshAgent;
    private bool gameOver = false;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (!gameOver)
        {
            
            if (player != null && player.gameObject.activeSelf)
            {
                
                navMeshAgent.SetDestination(player.position);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameOver = true;
        SceneManager.LoadScene(1);
        Debug.Log("Game Over"); 
    }
}


