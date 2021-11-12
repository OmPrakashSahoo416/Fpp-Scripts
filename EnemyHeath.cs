using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHeath : MonoBehaviour
{
    [SerializeField] float enemyHP = 100f;

    public void HitDamage(float damage)
    {
        enemyHP -= damage;
    }

    private void Update()
    {
        if (enemyHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
