using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingController : MonoBehaviour
{
    public GameObject fireball;
    public Transform gun;
    private float shootRate = 0.1f;
    private float shootForce = 600;
    private float m_shootRateTimeStamp = 0.5f;

    //sound effects
    private AudioSource fireBallAudio;

    // Start is called before the first frame update
    void Start()
    {
        fireBallAudio = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void shootObject()
    {
        //once the time is over fire rate time, spawn fireball inside of 'gun' and add force to rigid body
        if (Time.time > m_shootRateTimeStamp)
        {
            GameObject go = (GameObject)Instantiate(
            fireball, gun.position, gun.rotation);
            go.GetComponent<Rigidbody>().AddForce(gun.forward * shootForce);
            m_shootRateTimeStamp = Time.time + shootRate;
            //play fireball audio
            fireBallAudio.Play();
        }
    }

}
