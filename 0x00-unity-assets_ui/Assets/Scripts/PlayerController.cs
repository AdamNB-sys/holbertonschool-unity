using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
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

        if (controller.transform.position.y < -30.0f)
        {
            // Debug.Log("player fell");
            controller.enabled = false;
            transform.position = new Vector3(0, 50f, 0);
            controller.enabled = true;
        }

        direction.y = direction.y + (Physics.gravity.y * gravityMul * Time.deltaTime);
        controller.Move(direction * Time.deltaTime);

        // load menu when escape is pressed
        /**
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("MainMenu");
        }
        */
    }
}
