using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    static Animator animator;
    public CharacterController player;

    public bool isAirborne;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Move()
    {
        animator.SetBool("isRunning", true);
        animator.SetBool("isIdle", false);
    }

    public void Idle()
    {
        animator.SetBool("isRunning", false);
        animator.SetBool("isIdle", true);
    }

    public void Jump()
    {
        animator.SetTrigger("isJumping");
    }

    public void IsFalling()
    {
        isAirborne = true;
        animator.SetTrigger("isFalling");
    }

    public void IsGrounded()
    {
        isAirborne = false;
        animator.ResetTrigger("isFalling");
    }
}
