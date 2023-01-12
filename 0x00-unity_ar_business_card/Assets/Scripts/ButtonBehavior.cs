using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    public void GitHub()
    {
        Application.OpenURL("https://github.com/AdamNB-sys");
    }

    public void LinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/adambrummer/");
    }

    public void Email()
    {
        Application.OpenURL("mailto:a1adnat@gmail.com");
    }
}
