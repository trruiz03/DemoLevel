using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KilledEnemyTtacker : MonoBehaviour
{
    private float enemiesKilled = 0f;

    private static KilledEnemyTtacker m_instance;

    public GameObject bossEnemy;

    public float kills
    {
        get { return enemiesKilled; }
        set { enemiesKilled = value; }
    }
    public static KilledEnemyTtacker Instance
    { get { return m_instance; } }

    // Start is called before the first frame update
    void Start()
    {
        if (m_instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        m_instance = this;

        bossEnemy.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(kills == 5f)
        {
            bossEnemy.gameObject.SetActive(true);
        }
    }
}
