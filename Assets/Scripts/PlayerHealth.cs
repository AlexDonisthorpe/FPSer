using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHealth= 100;
    DisplayDamage damageUI;

    private void Start()
    {
        damageUI = FindObjectOfType<DisplayDamage>();
    }

    public void dealDamage(float damage)
    {
        playerHealth -= damage;
        damageUI.HandleHitFX();
        if(playerHealth <= 0)
        {
            FindObjectOfType<DeathHandler>().HandleDeath();
        }
    }
}
