using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    // create a public method which reduces hitpoints by the amount of damage

    public void TakeDamage(int damage)
    {
        hitPoints -= damage;
        Debug.Log(gameObject.name + ": I've been hit, my health is now " + hitPoints);

        if(hitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
