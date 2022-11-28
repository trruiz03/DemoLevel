using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{

    [SerializeField] float health, maxHealth = 5f;
    //private float swordDamage = 1.5f;
    //private float fireballDamage = 2;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage (float damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Enemy is dead");
        }
    }
}
