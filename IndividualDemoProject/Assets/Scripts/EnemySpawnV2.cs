using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnV2 : MonoBehaviour
{
    public GameObject enemyPrefab;
    private int xPos;
    private int zPos;
    private int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator EnemyDrop()
    {
        //spwan enemy in random position until enemy count reaches 15
        //grab a random cordinate from the x and z position given
        //spawn enemies inside of given range in random positions
        //wait .1 seconds before spawing 
        while (enemyCount < 15)
        {
            xPos = Random.Range(-205, -244);
            zPos = Random.Range(100, -100);
            Instantiate(enemyPrefab, new Vector3(xPos, 0.3f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
            //Determine enemy count and positions to verify random spawns
            Debug.Log("Enemy spawned at: " + enemyPrefab.transform.position);
            Debug.Log(enemyCount);
        }
    }
}
