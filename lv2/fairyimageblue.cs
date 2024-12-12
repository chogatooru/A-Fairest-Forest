using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fairyimageblue : MonoBehaviour {

    public threescore bscore;
    private Image image;

    public Sprite[] sprites;
    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        if (threescore.bscore <= 0)
        {
            image.sprite = sprites[0];
        }
        if (threescore.bscore >= 1)
        {
            image.sprite = sprites[1];
        }

    }

}
