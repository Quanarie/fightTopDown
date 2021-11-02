using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : AbilityToAttack
{
    [SerializeField] private Transform attackGoal;
    [SerializeField] private PlayerHealth playerHealth;

    private CircleCollider2D attackCircle;

    private void Start()
    {
        attackCircle = GetComponent<CircleCollider2D>();
    }

    private void Update()
    {
        if (Vector3.Distance(attackGoal.position, transform.position) <= attackCircle.radius)
        {
            if (Time.time - lastAttackTime < rechargeTime)
                return;

            Attack();
        }
    }

    private void Attack()
    {
        playerHealth.ReceiveDamage(damageAmount);
        lastAttackTime = Time.time;
    }
}
