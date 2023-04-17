using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHitPoints = 100f;

    DeathHandler deathHandler;

    void Start()
    {
        deathHandler = GetComponent<DeathHandler>();
    }

    public void TakeDamage(float damage)
    {
        playerHitPoints -= damage;

        if (playerHitPoints <= 0)
        {
            deathHandler.HandleDeath();
        }
    }
}
