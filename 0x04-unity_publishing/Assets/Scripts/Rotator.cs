using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Sets rotation rate of coin objects
/// </summary>
public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(45f * Time.deltaTime, 0f, 0f, Space.Self);
    }
}
