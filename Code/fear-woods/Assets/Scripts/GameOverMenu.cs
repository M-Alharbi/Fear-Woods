using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{

    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
     public void Restart(){
         SceneManager.LoadScene("Game");
    }

     public void backMainMenu(){
         SceneManager.LoadScene("StartMenu");
    }
}
