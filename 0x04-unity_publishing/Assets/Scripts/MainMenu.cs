using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Public class MainMenu
/// This handles all funcitonality of the
/// main menu, and handles the material 
/// change for color blind mode
/// </summary>
public class MainMenu : MonoBehaviour
{
    public Material trapMat;
    public Material goalMat;
    public Toggle colorblindMode;

    // Loads maze scene when Play button is selected
    public void PlayMaze()
    {
        if (colorblindMode.isOn)
        {
            trapMat.color = new Color32(255, 112, 0, 1);
            goalMat.color = Color.blue;
        }
        else
        {
            trapMat.color = Color.red;
            goalMat.color = Color.green;
        }
        SceneManager.LoadScene("maze");
    }

    // Quits application when Quit button is selected
    public void QuitMaze()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
