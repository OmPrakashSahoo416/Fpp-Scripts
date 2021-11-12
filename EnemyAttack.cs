using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth playerHealthScript;
    [SerializeField] float playerDamage = 40f;

    void Start()
    {
        playerHealthScript = FindObjectOfType<PlayerHealth>();
    }

    public void PlayerDamageAnimEvent()
    {
        playerHealthScript.HitDamage(playerDamage);
    }
}
