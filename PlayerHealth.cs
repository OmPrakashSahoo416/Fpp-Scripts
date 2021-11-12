using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHP = 150f;

    public void HitDamage(float damage)
    {
        playerHP -= damage;
    }

    private void Update()
    {
        if (playerHP <= 0)
        {
            Debug.Log("You ded.");
        }
    }
}
