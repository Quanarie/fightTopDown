using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HealthAbility : MonoBehaviour
{
    [SerializeField] protected float maxHp;

    protected float currentHp;

    private Color startColor;

    private void Start()
    {
        currentHp = maxHp;
        startColor = GetComponent<SpriteRenderer>().color;
    }

    public virtual void ReceiveDamage(float damageAmount)
    {
        currentHp -= damageAmount;

        if (currentHp <= 0)
        {
            currentHp = 0;
            Die();
        }

        GetComponent<SpriteRenderer>().color = Color.red;
        StartCoroutine(ReturnColor());
    }

    IEnumerator ReturnColor()
    {
        yield return new WaitForSeconds(0.3f);

        GetComponent<SpriteRenderer>().color = startColor;
    }

    protected virtual void Heal(float toHeal)
    {
        currentHp += toHeal;

        if (currentHp > maxHp)
        {
            currentHp = maxHp;
        }
    }

    protected virtual void Die() { }
}
