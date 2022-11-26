using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpScript : MonoBehaviour
{

    public bool powerupActive = false;
    shootingController script;
    OnButtonPress buttonScript;

    // Start is called before the first frame update
    void Start()
    {
        script = gameObject.GetComponent<shootingController>();
        script.enabled = false;

        buttonScript = gameObject.GetComponent<OnButtonPress>();
        buttonScript.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
            powerupActive = true;          
            script.enabled = true;
            buttonScript.enabled = true;

            Debug.Log("Power Up Status: " + powerupActive);
        }
    }
}
