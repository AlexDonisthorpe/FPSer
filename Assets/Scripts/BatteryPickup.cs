using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float intensityIncrease = 4;
    [SerializeField] float restoreAngle = 50f;

    private void OnTriggerEnter(Collider other)
    {
        FlashlightSystem flashlight = FindObjectOfType<FlashlightSystem>();
        flashlight.RestoreLightIntensity(intensityIncrease);
        flashlight.RestoreLightAngle(restoreAngle);
        Destroy(gameObject);
    }
}
