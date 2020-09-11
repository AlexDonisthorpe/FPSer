using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] int ammoAmount = 1;
    [SerializeField] AmmoType ammoType = default;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Ammo>().IncreaseCurrentAmmo(ammoType, ammoAmount);
            Destroy(gameObject, 1f);
        }
    }
}
