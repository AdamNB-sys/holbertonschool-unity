using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngie.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public void Back()
    {
        goBack();
    }

    public void goBack()
    {
        SceneManager.LoadScene(0);
    }
}
