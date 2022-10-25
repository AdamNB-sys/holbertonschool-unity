using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 5;
    public Rigidbody rb;

    // make cursor invisible
    // private void Start() 
    // {
    //     Cursor.lockState = CursorLockMode.Locked;
    //     Cursor.visible = false;
    // }

    // Update is called once per frame
    void Update()
    {
        // Player movement controller
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        //Vector3 inputDir = orientation.forward * vertical + orientation.right * horizontal;

        Vector3 moveInput = new Vector3(x, 0f, z).normalized;

        rb.velocity = moveInput * playerSpeed;


        // if (inputDir != Vector3.zero)
        //     playerObj.forward - Vector3.Slerp(playerObj.forward, inputDir.normalized, Time.deltaTime * rotationSpeed);
    }
}
