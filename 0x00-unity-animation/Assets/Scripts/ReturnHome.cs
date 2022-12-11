using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnHome : MonoBehaviour
{
    public void GoHome()
    {
        SceneManager.LoadScene(0);
    }
}
