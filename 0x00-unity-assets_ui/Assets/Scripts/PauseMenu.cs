using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //Play state
    public static bool isPaused = false;

    public GameObject PauseCanvas;

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        if (isPaused == false)
        {
            isPaused = true;
            Time.timeScale = 0f;
            PauseCanvas.SetActive(true);
        }
    }

    public void Resume()
    {
        if (isPaused == true)
        {
            isPaused = false;
            Time.timeScale = 1;
            PauseCanvas.SetActive(false);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Options()
    {
        SceneManager.LoadScene(1);
    }
}
