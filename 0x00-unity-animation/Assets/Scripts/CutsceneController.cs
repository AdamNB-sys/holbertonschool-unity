using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneController : MonoBehaviour
{
    public GameObject Camera;
    public GameObject PlayerController;
    public GameObject TimerCanvas;

    void Start() 
    {
        Cursor.visible = false;
        StartCoroutine(EndIntro());
    }

    IEnumerator EndIntro()
    {
        yield return new WaitForSeconds(3.0f);
        Camera.SetActive(true);
        TimerCanvas.SetActive(true);
        gameObject.SetActive(false);
        PlayerController.GetComponent<PlayerController>().enabled = true;
    }
}
