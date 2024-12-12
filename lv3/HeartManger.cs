using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartManger : MonoBehaviour {

    public PlayerHealth playerHealth;

    public AudioSource play;
    void OnMouseOver()
    {

        if (Global.flowercoll == true && Input.GetMouseButtonDown(1))
        {
            play.Play();
            playerHealth.currentHealth = 100;

            Global.flowercoll = false;
            Destroy(gameObject);

        }

    }

    void Update()
    {

        if (Global.flowercoll == true && Input.GetButtonDown("Bction"))
        {
            play.Play();
            playerHealth.currentHealth = 100;

            Global.flowercoll = false;
            Destroy(gameObject);

        }

    }
}
