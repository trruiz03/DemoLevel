using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordPowerup : MonoBehaviour
{
    private bool powerUpActive = false;
    public GameObject sword;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Yeh Im hit");
            powerUpActive = true;
            sword.gameObject.SetActive(true);
            sword.transform.position = this.transform.position;
            Destroy(this.gameObject);

        }

    }
}
