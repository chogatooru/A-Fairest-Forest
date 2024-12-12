using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flowr : MonoBehaviour
{
   

    private Image image;
    public Sprite[] sprites;

    float timer = 0;
    
    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        
        if (Global.flower == 1)
        {
            image.sprite = sprites[0];
            
        }
        else if (Global.flower == 2)
        {
            image.sprite = sprites[1];

        }
        else if (Global.flower == 3)
        {
            image.sprite = sprites[2];

                timer += Time.deltaTime;
                Debug.Log(timer);
                if (timer >= 1)
                {
                    Application.LoadLevel(3);
                }

          

        }
    }

}