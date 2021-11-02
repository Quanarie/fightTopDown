using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : AbilityToMove
{
    [SerializeField] private Transform goAfter;
    [SerializeField] private float chasingRadius;

    private CircleCollider2D attackCircle;

    private void Start()
    {
        attackCircle = GetComponent<CircleCollider2D>();
    }

    private void Update()
    {
        if (Vector3.Distance(goAfter.position, transform.position) <= attackCircle.radius)
            return;

        if (Vector3.Distance(goAfter.position, transform.position) <= chasingRadius)
        {
            UpdateMotor(new Vector3(goAfter.position.x - transform.position.x, goAfter.position.y - transform.position.y, 0));
        }
    }
}
