using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthone : MonoBehaviour {

    EnemyHealth enemyHealth;
    public GameObject HP2;
    public GameObject HP1;
	void Start () {
        enemyHealth = GetComponent<EnemyHealth>();

	}
	
	// Update is called once per frame
	void Update () {
        
        if (enemyHealth.currentHealth <= 20)
        {
            HP1.SetActive(true);
            HP2.SetActive(false);
        }
        if (enemyHealth.currentHealth <= 0)
        {
            threescore.rscore--;
            HP1.SetActive(false);
            Destroy(this);
        }

	}
        

}
