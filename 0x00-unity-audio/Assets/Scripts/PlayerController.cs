using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public AnimationController animator;
    public CharacterController controller;
    public Transform camera;
    public Transform player;


    public float speed = 5f;
    public float gravityMul;
    public float jumpForce;

    private Vector3 direction;

    void Awake() 
    {
        controller = GetComponent<CharacterController>();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed;
        float vertical = Input.GetAxis("Vertical") * speed;

        if (horizontal == 0 && vertical == 0)
        {
            animator.Idle();
        }
        else
        {
            animator.Move();
        }

        // Sets movement direction to camera orientation
        direction = Quaternion.Euler(0, camera.transform.eulerAngles.y, 0) * new Vector3(horizontal, direction.y, vertical);

        // Sets gravity for player
        direction.y = direction.y + (Physics.gravity.y * gravityMul * Time.deltaTime);

        // Enable player movement
        controller.Move(direction * Time.deltaTime);

        var amIJumping = false;

        // Enable player jump
        if (controller.isGrounded)
        {
            Debug.Log("We're on the ground...");
            direction.y = 0f;
            if (Input.GetKeyDown("space"))
            {
                animator.Jump();
                amIJumping = true;
                direction.y = jumpForce;
            }
            else
            {
                animator.IsGrounded();
            }
        }
        else
        {
            if (!amIJumping)
            {
                animator.IsFalling();
            }
        }

        // Fall check and respawn
        if (controller.transform.position.y < -30.0f)
        {
            controller.enabled = false;
            transform.position = new Vector3(0, 50f, 0);
            controller.enabled = true;
        }
    }
}
