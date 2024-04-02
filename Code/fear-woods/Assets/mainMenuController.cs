using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenuUI;
    private bool menuActive = false;

    void Start()
    {
        
        mainMenuUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            
            ToggleMainMenu();
        }
    }

    public void ToggleMainMenu()
    {
        // Toggle the menuActive flag
        menuActive = !menuActive;
        
        mainMenuUI.SetActive(menuActive);
        
        Cursor.visible = menuActive;
        Cursor.lockState = menuActive ? CursorLockMode.None : CursorLockMode.Locked;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
        SceneManager.LoadScene(0);
    }
}