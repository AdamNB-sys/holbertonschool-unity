using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public Transform camera;
    public Transform player;

    public float speed = 5f;
    public float gravityMul;
    public float jumpForce;

    private Vector3 direction;

    // public float turnSmoothTime = 0.1f;
    // float smoothVelocity;

    void Awake() 
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed;
        float vertical = Input.GetAxis("Vertical") * speed;
        direction = Quaternion.Euler(0, camera.transform.eulerAngles.y, 0) * new Vector3(horizontal, direction.y, vertical);

        if (controller.isGrounded)
        {
            direction.y = 0f;
            if (Input.GetKeyDown("space"))
            {
                direction.y = jumpForce;
            }
        }

        if (controller.transform.position.y < -20.0f)
        {
            // Debug.Log("player fell");
            controller.enabled = false;
            transform.position = new Vector3(0, 20, 0);
            controller.enabled = true;
        }

        direction.y = direction.y + (Physics.gravity.y * gravityMul * Time.deltaTime);
        controller.Move(direction * Time.deltaTime);
    }
}
