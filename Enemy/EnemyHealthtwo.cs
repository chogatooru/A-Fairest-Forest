using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthtwo : MonoBehaviour {

    EnemyHealth enemyHealth;
    public GameObject HP4;
    public GameObject HP3;
    public GameObject HP2;
    public GameObject HP1;
    void Start()
    {
        enemyHealth = GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (enemyHealth.currentHealth <= 60)
        {
            HP3.SetActive(true);
            HP4.SetActive(false);
        }
        if (enemyHealth.currentHealth <= 40)
        {
            HP2.SetActive(true);
            HP3.SetActive(false);
        }
        if (enemyHealth.currentHealth <= 20)
        {
            HP1.SetActive(true);
            HP2.SetActive(false);
        }
        if (enemyHealth.currentHealth <= 0)
        {
            threescore.bscore--;
            HP1.SetActive(false);
            Destroy(this);
        }
    }
}
