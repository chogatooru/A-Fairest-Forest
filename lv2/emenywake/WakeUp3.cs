﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUp3 : MonoBehaviour {

    public AudioSource Awake;
    public Animator anim;
    public int timewake;
    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            timewake++;

            if (timewake == 1)
            {
                anim.SetTrigger("enemyAwake");
                GameObject.Find("fairy (3)").GetComponent<EnemyMovement>().enabled = true;
                Awake.Play();
            }

        }
    }
	
}
