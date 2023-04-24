using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : MonoBehaviour
{

    private float swordDamage = 1.5f;
    private float fireballDamage = 2;
    public AudioSource enemyAudio;

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
        //determine that a melee weapon is interacting with the enemy
        if (other.gameObject.CompareTag("Enemy") && gameObject.CompareTag("melee"))
        {
            //grab audio source from gameobject script is attatched to
            AudioSource source = gameObject.GetComponent<AudioSource>();

            //see if enemy has enemy health script, if so decrease sword damage from health
            if (other.gameObject.TryGetComponent<enemyHealth>(out enemyHealth enemyComponent))
            {
                source.Play();
                enemyComponent.takeDamage(swordDamage);
                Debug.Log("Enemy has taken 1.5 damage");
                
            }

        }

        //determine that a fireball is interacting with the enemy
        else if (other.gameObject.CompareTag("Enemy") && gameObject.CompareTag("fireball"))
        {
            //see if enemy has enemy health script, if so decrease fireball damage from health
            if (other.gameObject.TryGetComponent<enemyHealth>(out enemyHealth enemyComponent))
            {
                enemyComponent.takeDamage(fireballDamage);
                Destroy(this.gameObject);
                Debug.Log("Enemy has taken 2 damage");

            }


        }
    }
}
