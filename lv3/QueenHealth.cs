using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QueenHealth : MonoBehaviour {

    public EnemyHealth enemyHealth;
    private Image image;
    
    public Sprite[] sprites;

    float timer = 0;
    void Start()
    {
        image = GetComponent<Image>();
        
    }

    void Update()
    {
        if (enemyHealth.currentHealth <= 380)
        {
            image.sprite = sprites[0];
        }
        if (enemyHealth.currentHealth <= 360)
        {
            image.sprite = sprites[1];
        }
        if (enemyHealth.currentHealth <= 340)
        {
            image.sprite = sprites[2];
        }
        if (enemyHealth.currentHealth <= 320)
        {
            image.sprite = sprites[3];
        }
        if (enemyHealth.currentHealth <= 300)
        {
            image.sprite = sprites[4];
        }
        if (enemyHealth.currentHealth <= 280)
        {
            image.sprite = sprites[5];
        }
        if (enemyHealth.currentHealth <= 260)
        {
            image.sprite = sprites[6];
        }
        if (enemyHealth.currentHealth <= 240)
        {
            image.sprite = sprites[7];
        }
        if (enemyHealth.currentHealth <= 220)
        {
            image.sprite = sprites[8];
        }
        if (enemyHealth.currentHealth <= 200)
        {
            image.sprite = sprites[9];
        }
        if (enemyHealth.currentHealth <= 180)
        {
            image.sprite = sprites[10];
        }
        if (enemyHealth.currentHealth <= 160)
        {
            image.sprite = sprites[11];
        }
        if (enemyHealth.currentHealth <= 140)
        {
            image.sprite = sprites[12];
        }
        if (enemyHealth.currentHealth <= 120)
        {
            image.sprite = sprites[13];
        }
        if (enemyHealth.currentHealth <= 100)
        {
            image.sprite = sprites[14];
        }
        if (enemyHealth.currentHealth <= 80)
        {
            image.sprite = sprites[15];
        }
        if (enemyHealth.currentHealth <= 60)
        {
            image.sprite = sprites[16];
        }
        if (enemyHealth.currentHealth <= 40)
        {
            image.sprite = sprites[17];
        }
        if (enemyHealth.currentHealth <= 20)
        {
            image.sprite = sprites[18];
        }
        if (enemyHealth.currentHealth <= 0)
        {
            
            Debug.Log(timer);
            timer += Time.deltaTime;
            image.sprite = sprites[19];
            if (timer >= 3) { 
            Application.LoadLevel(12);
            }
        }
    }
}
