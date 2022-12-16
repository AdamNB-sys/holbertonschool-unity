using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    static Animator animator;
    public CharacterController player;

    public bool isAirborne = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isRunning", true);
            animator.SetBool("isIdle", false);
        }
        else
        {
            animator.SetBool("isRunning", false);
            animator.SetBool("isIdle", true);
        }

        if (Input.GetKeyDown("space"))
        {
            animator.SetTrigger("isJumping");
        }

        if (player.transform.position.y == 50f)
        {
            isAirborne = true;
            animator.SetTrigger("isFalling");
        }

        if (player.isGrounded)
        {
            isAirborne = false;
            animator.ResetTrigger("isFalling");
        }
    }
}
