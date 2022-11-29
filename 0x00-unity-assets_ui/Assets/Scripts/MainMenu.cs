using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Enables cursor and locks to window
    void Start() 
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Enables level select
    public void LevelSelect(int level)
    {
        SceneManager.LoadScene(level);
    }

    // Quit game
    public void QuitGame()
    {
        Application.Quit();
    }
}
