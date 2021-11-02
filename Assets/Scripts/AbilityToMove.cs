using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbilityToMove : MonoBehaviour
{
    [SerializeField] private float ySpeed;
    [SerializeField] private float xSpeed;

    private Vector3 moveDelta;
    
    protected virtual void UpdateMotor(Vector3 input)
    {
        moveDelta = new Vector3(input.normalized.x * xSpeed, input.normalized.y * ySpeed, 0);

        transform.Translate(moveDelta.x * Time.deltaTime, moveDelta.y * Time.deltaTime, 0);
    }
}
