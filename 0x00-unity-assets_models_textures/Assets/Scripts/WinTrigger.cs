using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public Timer stopWatch;
    public Text timerText;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("WINNER");
        if (other.gameObject.CompareTag("Player"))
        {
            stopWatch.enabled = false;
            timerText.color = Color.green;
            timerText.fontSize = 60;
        }
    }
}
