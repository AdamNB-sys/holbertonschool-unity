using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    public Text WinText;
    public float seconds = 0;

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        string m = ((int) seconds / 60).ToString();
        string s = (seconds % 60).ToString("f2");
        TimerText.text = m + ":" + s;
    }

    /**
    public void Win()
    {

    }
    */
}
