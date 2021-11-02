using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : HealthAbility
{
    protected override void Die()
    {
        Destroy(gameObject);
    }
}
