using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteOnColision : MonoBehaviour
{
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
        if(other.CompareTag("Enemy"))
        {
            //When two object collide, destroy each other
            Destroy(gameObject);
            Destroy(other.gameObject);
            Debug.Log("I dont know how but this works");
        }

    }


}
