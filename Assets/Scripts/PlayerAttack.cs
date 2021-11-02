using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : AbilityToAttack
{
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

    }
}
