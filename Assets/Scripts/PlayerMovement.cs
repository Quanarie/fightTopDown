using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : AbilityToMove
{
    private void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        UpdateMotor(new Vector3(inputX, inputY, 0));
    }
}
