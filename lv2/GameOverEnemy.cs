using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOverEnemy : MonoBehaviour {

    public PlayerHealth playerHealth;


    Animator anim;


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {

        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");
        }
    }


}

