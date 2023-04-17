using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoreAngle = 90f;
    [SerializeField] float addIntensity = 1f;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FlashlightSystem flashlightSystem;
            flashlightSystem = other.GetComponentInChildren<FlashlightSystem>();

            flashlightSystem.RestoreLightAngle(restoreAngle);
            flashlightSystem.AddLightIntensity(addIntensity);

            Destroy(gameObject);
        }
    }
}
