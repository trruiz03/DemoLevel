using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyHealth : MonoBehaviour
{

    [SerializeField] float health, maxHealth = 5f;

    private NavMeshAgent Enemy;
    public GameObject Player;
    private float EnemyDistanceRun = 12.0f;

    private int xPos;
    private int zPos;
    private float yPos = 0.4f;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        Enemy = GetComponent<NavMeshAgent>();

        StartCoroutine(EnemyDrop());
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if(distance < EnemyDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 newPos = transform.position - dirToPlayer;

            Enemy.SetDestination(newPos);
        }
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

    private IEnumerator EnemyDrop()
    {
        //spwan enemy in random position until enemy count reaches 15
        //grab a random cordinate from the x and z position given
        //spawn enemies inside of given range in random positions
        //wait .1 seconds before spawing 
            xPos = Random.Range(20, -10);
            zPos = Random.Range(50, -50);
            transform.position = transform.position + new Vector3(xPos, yPos, zPos);
            yield return new WaitForSeconds(0.1f);
            Debug.Log("Enemy spawned at: " + this.gameObject.transform.position);
    }
}
