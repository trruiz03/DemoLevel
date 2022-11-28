using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : MonoBehaviour
{

    private float swordDamage = 1.5f;
    private float fireballDamage = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Enemy") && gameObject.CompareTag("melee"))
        {


            if (other.gameObject.TryGetComponent<enemyHealth>(out enemyHealth enemyComponent))
            {
                enemyComponent.takeDamage(swordDamage);
                Debug.Log("Enemy has taken 1.5 damage");

            }

        }

        else if (other.gameObject.CompareTag("Enemy") && gameObject.CompareTag("fireball"))
        {

            if (other.gameObject.TryGetComponent<enemyHealth>(out enemyHealth enemyComponent))
            {
                enemyComponent.takeDamage(fireballDamage);
                Destroy(this.gameObject);
                Debug.Log("Enemy has taken 2 damage");

            }


        }
    }
}
