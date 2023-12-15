using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStrikeDistanceCheck : MonoBehaviour
{
    public GameObject playerTarget { get; set; }
    private Enemy enemy;

    private void Awake()
    {
        playerTarget = GameObject.FindGameObjectWithTag("Player");
        enemy = GetComponentInParent<Enemy>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == playerTarget)
        {
            enemy.setStrikingDistanceBool(true);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject == playerTarget)
        {
            enemy.setStrikingDistanceBool(false);
        }
    }
}
