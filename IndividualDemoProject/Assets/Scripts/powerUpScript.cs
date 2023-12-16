using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpScript : MonoBehaviour
{

    public bool powerupActive = false;

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
        //When interacting with the power up, destroy powerup prefab and toggle the on button press script
        if (other.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
            powerupActive = true;          

            //verify powerup status
            Debug.Log("Power Up Status: " + powerupActive);
        }
    }
}
