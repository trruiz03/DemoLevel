using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAggroCheck : MonoBehaviour
{
    public GameObject PlayerTarget { get; set; }
    private Enemy enemy;

    private void Awake()
    {
        PlayerTarget = GameObject.FindGameObjectWithTag("Player");

        enemy = GetComponentInParent<Enemy>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject == PlayerTarget)
        {
            enemy.setAggroStatus(true);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject == PlayerTarget)
        {
            enemy.setAggroStatus(false);
        }
    }
}
