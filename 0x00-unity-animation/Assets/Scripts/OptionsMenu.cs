using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    // Enables cursor and locks to window
    void Start() 
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Load previous scene (kinda)
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
