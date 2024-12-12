using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fairyscoreyellow : MonoBehaviour {

    public threescore yscore;
    private Image image;

    public Sprite[] sprites;
    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        if (threescore.yscore <= 0)
        {
            image.sprite = sprites[0];
        }
        if (threescore.yscore >= 1)
        {
            image.sprite = sprites[1];
        }

    }
}
