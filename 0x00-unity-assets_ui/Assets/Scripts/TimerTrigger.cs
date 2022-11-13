using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerTrigger : MonoBehaviour
{
    public Timer stopWatch;

    void OnTriggerExit(Collider other) 
    {
        Debug.Log("YAAA");
        if (other.gameObject.CompareTag("Player"))
        {
            stopWatch.enabled = true;
        }
    }
}
