using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    // Enable cursor
    void Update()
    {
        Cursor.visible = true;
    }

    // Load main menu
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    // Load next scene
    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
