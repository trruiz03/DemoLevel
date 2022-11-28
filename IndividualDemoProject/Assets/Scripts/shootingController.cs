using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingController : MonoBehaviour
{
    public float moveForce;
    public GameObject fireball;
    public Transform gun;
    public float shootRate;
    public float shootForce;
    private float m_shootRateTimeStamp = 0.05f;

    //sound effects
    public AudioSource fireBallAudio;
    public AudioClip fireBallClip;

    // Start is called before the first frame update
    void Start()
    {
        //fireBallAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void shootObject()
    {
         if (Time.time > m_shootRateTimeStamp)
            {
                GameObject go = (GameObject)Instantiate(
                fireball, gun.position, gun.rotation);
                go.GetComponent<Rigidbody>().AddForce(gun.forward * shootForce);
                m_shootRateTimeStamp = Time.time + shootRate;
            }
        //fireBallAudio.PlayOneShot(fireBallClip, 1.0f);

    }

}
