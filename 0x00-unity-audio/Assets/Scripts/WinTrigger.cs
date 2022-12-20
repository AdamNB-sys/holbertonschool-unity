using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{
    public Timer stopWatch;
    public Text timerText;
    public GameObject WinCanvas;
    // public AudioSource BackgroundMusic;
    public CharacterController controller;

    // void Start() 
    // {
    //     if (WinCanvas.IsActive)
    //     {
    //         BackgroundMusic.Stop();
    //     }
    // }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            stopWatch.enabled = false;
            controller.enabled = false;
            timerText.color = Color.green;
            timerText.fontSize = 60;
            WinCanvas.SetActive(true);
        }
    }
}
