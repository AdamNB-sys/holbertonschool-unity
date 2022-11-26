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
        // Debug.Log("Updating...");
        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("Escase key pressed");
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
        // Debug.Log("ES-CA-PE!");
        if (isPaused == false)
        {
            isPaused = true;
            Time.timeScale = 0f;
            PauseCanvas.SetActive(true);
        }
    }

    public void Resume()
    {
        // Debug.Log("RE-SU-ME!");
        if (isPaused == true)
        {
            isPaused = false;
            Time.timeScale = 1;
            PauseCanvas.SetActive(false);
        }
    }
}
