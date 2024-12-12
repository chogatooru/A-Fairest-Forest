using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QueenWakeUP : MonoBehaviour {

    public AudioSource Awake;
    public Animator anim;
    public int timewake;
    public GameObject Queen;
    public GameObject QuehealthImage;

 
    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            timewake++;

            if (timewake == 1)
            {

                QuehealthImage.SetActive(true);
                anim.SetTrigger("enemyAwake");
                Queen.GetComponent<EnemyMovement>().enabled = true;
                Awake.Play();
            }

        }
    }
	
}
