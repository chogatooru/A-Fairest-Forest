using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUp11 : MonoBehaviour {

    public AudioSource Awake;
    public Animator anim;
    public int timewake;
    public GameObject fairy;
 


    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            timewake++;

            if (timewake == 1)
            {
                anim.SetTrigger("enemyAwake");
                fairy.GetComponent<EnemyMovement>().enabled = true;
                Awake.Play();
            }
        }
    }
	
}
