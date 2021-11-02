using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : AbilityToMove
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        UpdateMotor(new Vector3(inputX, inputY, 0));

        animator.SetFloat("moveX", inputX);
        animator.SetFloat("moveY", inputY);

        if (inputX != 0 || inputY != 0)
        {
            animator.SetFloat("prevMoveX", inputX);
            animator.SetFloat("prevMoveY", inputY);
        }
    }
}
