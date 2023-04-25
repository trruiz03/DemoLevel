using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wandPowerup : MonoBehaviour
{
    private bool powerUpActive = false;
    public GameObject wand;
    private int xPos;
    private int zPos;
    private float yPos = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(powerUpDrop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Yeh Im hit");
            powerUpActive = true;
            wand.gameObject.SetActive(true);
            wand.transform.position = this.transform.position;
            Destroy(this.gameObject);

        }

    }

    IEnumerator powerUpDrop()
    {
        //grab a random cordinate from the x and z position given
        //spawn powerup inside of given range in a random position
        //wait .1 seconds before spawing 
        xPos = Random.Range(-230, -260);
        zPos = Random.Range(50, -50);
        transform.position = transform.position + new Vector3(xPos, yPos, zPos);
        yield return new WaitForSeconds(0.1f);
        //find the powerup position to very random spawn
        Debug.Log("Powerup spawned at: " + this.gameObject.transform.position);
    }
}
