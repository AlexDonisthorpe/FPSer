using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    PlayerHealth target;
    [SerializeField] float damage = 40f;
    
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    public void AttackHitEvent()
    {
        if (target == null) return;
        try
        {
            target.dealDamage(damage);
        }
        catch (Exception e)
        {
            print(e.Message);
        }
    }
}
