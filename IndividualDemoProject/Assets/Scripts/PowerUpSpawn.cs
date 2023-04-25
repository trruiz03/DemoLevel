using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawn : MonoBehaviour
{
    public GameObject powerUp;
    private int xPos;
    private int zPos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(powerUpDrop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator powerUpDrop()
    {
        //grab a random cordinate from the x and z position given
        //spawn powerup inside of given range in a random position
        //wait .1 seconds before spawing 
        xPos = Random.Range(-223, -250);
        zPos = Random.Range(50, -50);
        Instantiate(this.gameObject, new Vector3(xPos, 0.4f, zPos), Quaternion.identity);
        yield return new WaitForSeconds(0.1f);
        //find the powerup position to very random spawn
        Debug.Log("Powerup spawned at: " + powerUp.transform.position);
    }
}
