using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    bool isDead = false;

    // create a public method which reduces hitpoints by the amount of damage

    public void TakeDamage(int damage)
    {
        BroadcastMessage("OnDamageTaken");
        hitPoints -= damage;

        if(hitPoints <= 0)
        {
            if (isDead) return;
            isDead = true;
            GetComponent<EnemyAI>().HandleDeath();
        }
    }

    public bool IsDead()
    {
        return isDead;
    }
}
