using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fairyimage : MonoBehaviour {

    public threescore rscore;
    private Image image;
  
    public Sprite[] sprites;
    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        if (threescore.rscore<= 0)
        {
            image.sprite = sprites[0];
        }
        if (threescore.rscore >= 1)
        {
            image.sprite = sprites[1];
        }
        
    }
	
}
