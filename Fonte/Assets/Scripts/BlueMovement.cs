using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove;
    bool jump = false;
    bool crounch = false;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("HorizontalB") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));


        if (Input.GetButtonDown("JumpW"))
        {
            animator.SetBool("Jump", true);
            jump = true;
        }
        if (Input.GetButtonDown("CrounchS"))
        {
            crounch = true;
        }else if (Input.GetButtonUp("CrounchS"))
        {
            crounch = false;
        }
    }

    public void onLanding()
    {
        animator.SetBool("Jump", false);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crounch, jump);
        jump = false;
    }
}
