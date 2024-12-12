using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shootnumberimage : MonoBehaviour {

    public shootnuv shootnumber;
    private Image image;
  
    public Sprite[] sprites;
    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        if (shootnuv.shootnumber <= 0)
        {
            image.sprite = sprites[0];
        }
        if (shootnuv.shootnumber >= 1)
        {
            image.sprite = sprites[1];
        }
        
    }
}
