using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthImage : MonoBehaviour {

    public PlayerHealth playerHealth;
    private Image image;
    //指定两张sprite图片
    public Sprite[] sprites;
    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        if (playerHealth.currentHealth >= 90)
        {
            image.sprite = sprites[10];
        }
        if (playerHealth.currentHealth <= 90)
        {
            image.sprite = sprites[0];
        }
        if (playerHealth.currentHealth <= 80)
        {
            image.sprite = sprites[1];
        }
        if (playerHealth.currentHealth <= 70)
        {
            image.sprite = sprites[3];
        }
        if (playerHealth.currentHealth <= 60)
        {
            image.sprite = sprites[4];
        }
        if (playerHealth.currentHealth <= 50)
        {
            image.sprite = sprites[5];
        }
        if (playerHealth.currentHealth <= 40)
        {
            image.sprite = sprites[6];
        }
        if (playerHealth.currentHealth <= 30)
        {
            image.sprite = sprites[7];
        }
        if (playerHealth.currentHealth <= 20)
        {
            image.sprite = sprites[8];
        }
        if (playerHealth.currentHealth <= 0)
        {
            image.sprite = sprites[9];
        }
    }

}
