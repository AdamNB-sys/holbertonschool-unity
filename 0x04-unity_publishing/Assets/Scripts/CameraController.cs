using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Public class CameraController
/// Handles the camera movement to
/// follow the player at a set offset
/// at all times.
/// </summary>
public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // Locks main camera to player position with offset
        transform.position = player.transform.position + offset;
    }
}
