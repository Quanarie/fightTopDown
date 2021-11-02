using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : AbilityToAttack
{
    private EnemyHealth enemyHealth;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Time.time - lastAttackTime < rechargeTime)
                return;

            Attack();
            lastAttackTime = Time.time;
        }
    }

    private void Attack()
    {
        animator.SetTrigger("attack");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out enemyHealth))
        {
            enemyHealth.ReceiveDamage(damageAmount);
        }
    }
}
