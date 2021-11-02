using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityToAttack : MonoBehaviour
{
    [SerializeField] protected float damageAmount;
    [SerializeField] protected float rechargeTime;

    protected float lastAttackTime;
}
